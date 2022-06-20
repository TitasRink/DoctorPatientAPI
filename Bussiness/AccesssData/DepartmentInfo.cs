
using FrameworkData.DataContext;
using FrameworkData.Model;
using System.Collections.Generic;
using System.Linq;

namespace Bussiness.AccesssData

{
    public class DepartmentInfo
    {
        public void CreatDepartment(string name, string address)
        {
            var context = new DataConection();
            
            DepartmentModel dep = new DepartmentModel(name, address);
            context.Departments.Add(dep);
            context.SaveChanges();
        }
        public List<DepartmentModel> GetDepartment()
        {
            var context = new DataConection();
            var returnData = context.Departments.ToList();
            return returnData;
        }
        public void CreatDepartment(string depName, string depAddress, int docNumber, int patNumber)
        {
            var context = new DataConection();

            List<DoctorModel> doc = new List<DoctorModel>();
            for (int i = 0; i < docNumber; i++)
            {
                doc.Add(new DoctorModel($"FirstName{i}", $"LastName{i}", 20+i));
            }

            List<PatientModel> pat = new List<PatientModel>();
            for (int i = 0; i < patNumber; i++)
            {
                pat.Add(new PatientModel($"FirstName{i}", $"LastName{i}"));
            }

            //for (int i = 0; i < pat.Count; i++)
            //{
            //    pat[i].doctors.AddRange(doc);
            //}

            context.Departments.Add(new DepartmentModel(depName, depAddress, doc, pat));
            context.SaveChanges();
        }

        public void AddDoctors(int depId , int doctorsNum)
        {
            var context = new DataConection();
            var dep = context.Departments.Where(x=>x.Id == depId).SingleOrDefault();
            var doc = context.Doctors.ToList();
            for (int i = 0; i < doctorsNum; i++)
                {
                    foreach (var item in doc)
                    {
                        dep.doctors.Add(item);
                    }                    
                }
            context.Departments.Add(new DepartmentModel(depName, depAddress, doc, pat));
             context.SaveChanges();
        }
    }
}
