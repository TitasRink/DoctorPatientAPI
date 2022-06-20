using FrameworkData.DataContext;
using FrameworkData.Model;
using System.Collections.Generic;
using System.Linq;

namespace Bussinesss.AccesssData
{
    public class DoctorInfo
    {
        public void CreatDoctor(string name, string lastname, int age)
        {
            var context = new DataConection();
            DoctorModel doc = new DoctorModel(name,lastname,age);
            context.Doctors.Add(doc);
            context.SaveChanges();
        }
        public void AddToDepartment(int depId, int doctorNum)
        {
            var context = new DataConection();
            var dep = context.Departments.Where(x => x.Id == depId).SingleOrDefault();
            var doc = context.Doctors.Where(x => x.Id == doctorNum).SingleOrDefault();
            dep.doctors.Add(doc);
            context.SaveChanges();
        }
        public List<DoctorModel> GetDepartmentDoctors(int depID)
        {
            var context = new DataConection();
            var result = context.Doctors.Where(x => x.DepartmentModelId == depID).ToList();
            return result;
        }
        public List<DoctorModel> Doctorinfo(int docId)
        {
            var context = new DataConection();
            //var rr = context.Doctors.Where(x => docId == x.patients.);
            var dd = context.Doctors.Where(x => x.Id == docId).ToList();
            
            return (List<DoctorModel>)dd;
        }
       
        public void Addpat(int docNum, int patNum)
        {
            var context = new DataConection();
            var dep = context.Doctors.Where(x => x.Id == docNum).SingleOrDefault();
            var doc = context.Patients.Where(x => x.Id == patNum).SingleOrDefault();
            dep.patients.Add(doc);
            context.SaveChanges();
        }
    }
}
