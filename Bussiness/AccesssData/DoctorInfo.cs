using FrameworkData.DataContext;
using FrameworkData.Model;

namespace Bussiness.AccesssData
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
    }
}
