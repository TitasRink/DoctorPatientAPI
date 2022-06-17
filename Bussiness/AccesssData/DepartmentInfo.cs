
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
            using (var context = new DataConection())
            {
                if (context.Departments == null)
                {
                    DepartmentModel dep = new DepartmentModel(name, address);
                    context.Departments.Add(dep);
                    context.SaveChanges();
                }
            }
        }
        public List<DepartmentModel> GetDepartment()
        {
            using (var context = new DataConection())
            {
                var returnData = context.Departments.ToList();
                return returnData;
            }
        }
        public void AddDoctors(int depId , int doctorsNum)
        {
            using (var context = new DataConection())
            {
                var dep = context.Departments.Where(x=>x.Id == depId).SingleOrDefault();
                var doc = context.Doctors.ToList();
                for (int i = 0; i < doctorsNum; i++)
                {
                    foreach (var item in doc)
                    {
                        dep.doctors.Add(item);
                    }                    
                }

                context.SaveChanges();
            }
        }
    }
}
