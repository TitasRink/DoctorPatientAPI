using FrameworkData.DataContext;
using FrameworkData.Model;
using System.Collections.Generic;
using System.Linq;

namespace Bussiness.AccesssData
{
    public class PatientInfo
    {
        public void CreatPatient(string name, string address)
        {
            var context = new DataConection();
            PatientModel pat = new PatientModel(name, address);
            context.Patients.Add(pat);
            context.SaveChanges();
        }
        public void AddToDepartament(int depId, int patientNum)
        {
            var context = new DataConection();
            var dep = context.Departments.Where(x => x.Id == depId).SingleOrDefault();
            var doc = context.Patients.Where(x => x.Id == patientNum).SingleOrDefault();
            dep.patients.Add(doc);
            context.SaveChanges();
        }
        public List<PatientModel> GetDepartmentPatients(int depID)
        {
            var context = new DataConection();
            var result = context.Patients.Where(x => x.DepartmentModelId == depID).ToList();

            return result;
        }
    }
}
