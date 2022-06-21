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
        // kolkas nenaudojama tik testavimui
        //public void AddToDepartament(int depId, int patientId)
        //{
        //    var context = new DataConection();
        //    var dep = context.Departments.Where(x => x.Id == depId).SingleOrDefault();
        //    var doc = context.Patients.Where(x => x.Id == patientId).SingleOrDefault();
        //    dep.patients..Add(doc);
        //    context.SaveChanges();
        //}
    }
}
