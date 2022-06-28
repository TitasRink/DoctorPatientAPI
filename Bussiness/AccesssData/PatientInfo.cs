using FrameworkData.DataContext;
using FrameworkData.Model;
using Microsoft.EntityFrameworkCore;
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
        public List<PatientModel> ShowDepPatients(int depId)
        {
            var context = new DataConection();
            var result = context.Departments.Include(d => d.patients).FirstOrDefault(d => d.Id == depId).patients.ToList();
            return result;
        }
        public List<PatientModel> ShowDocPatients(int docId)
        {
            var context = new DataConection();
            var result = context.Doctors.Include(d => d.patients).FirstOrDefault(d => d.Id == docId).patients.ToList();
       
            return result;
        }
    }
}
