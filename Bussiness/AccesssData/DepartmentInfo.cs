
using FrameworkData.DataContext;
using FrameworkData.Model;
using System.Collections.Generic;

namespace Bussiness.AccesssData

{
    public class DepartmentInfo
    {
        public void CreatDepartment(string name, string address)
        {
            using (var context = new DataConection())
            {
                DepartmentModel dep = new DepartmentModel(name, address);
                context.Departments.Add(dep);
                context.SaveChanges();
            }
        }
    }
    //public void AddDoctors(DepartmentModel department)
    //{
    //    using (var context = new DataConection())
    //    {
    //        List<DoctorModel> doctor = new List<DoctorModel>();

    //        doctor.Add(new DoctorModel("asd", "dasd"));

    //        context.Departments.Add(department);
    //        context.SaveChanges();
    //    }
    //}
}
