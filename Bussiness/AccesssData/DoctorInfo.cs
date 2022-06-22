using FrameworkData.DataContext;
using FrameworkData.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Bussiness.AccesssData
{
    public class DoctorInfo
    {
        public void CreatDoctor(string name, string lastname, int age, int id)
        {
            var context = new DataConection();
            DoctorModel doc = new DoctorModel(name,lastname,age, id);
            context.Add(doc);
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
            var docInfo = context.Doctors.Where(x => x.Id == docId).ToList();
            
            return (List<DoctorModel>)docInfo;
        }
        public void AddPatientToDoctor(int docNum, int patNum)
        {
            var context = new DataConection();
            var doc = context.Doctors.Where(x => x.Id == docNum).FirstOrDefault();
            var pat = context.Patients.Include(i=>i.doctors).Where(x => x.Id == patNum).FirstOrDefault();
            doc.patients.Add(pat);
            
            pat.doctors.Clear();
        
            context.SaveChanges();
        }
    }
}
