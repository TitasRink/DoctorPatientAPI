using FrameworkData.DataContext;
using FrameworkData.Model;

namespace Bussiness.AccesssData
{
    public class DoctorInfo
    {
        public void CreatDoctor(string name, string address)
        {
            using (var context = new DataConection())
            {
                DoctorModel doc = new DoctorModel(name, address);
                context.Doctors.Add(doc);
                context.SaveChanges();
            }
        }
    }
}
