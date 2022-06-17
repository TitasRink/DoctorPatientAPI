using FrameworkData.DataContext;
using FrameworkData.Model;

namespace Bussiness.AccesssData
{
    public class PatientInfo
    {
        public void CreatPatient(string name, string address)
        {
            using (var context = new DataConection())
            {
                if (context.Patients == null)
                {
                    PatientModel pat = new PatientModel(name, address);
                    context.Patients.Add(pat);
                    context.SaveChanges();
                }
              
            }
        }
    }
}
