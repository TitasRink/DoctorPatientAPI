using FrameworkData.DataContext;
using FrameworkData.Model;

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
    }
}
