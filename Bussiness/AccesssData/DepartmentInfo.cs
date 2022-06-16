
using FrameworkData.DataContext;
using FrameworkData.Model;
using System.Collections.Generic;

namespace Bussiness.AccesssData

{
    public class DepartmentInfo
    {
        public void CreatDepartment()
        {
            
            DataConection db = new DataConection();

            List<DoctorModel> depart = new List<DoctorModel>
            {
                new DoctorModel("pirmas vardas","pirma pavarde"),
                new DoctorModel("antras vardas","antra pavarde"),
                new DoctorModel("trecias vardas","trecia pavarde"),

            };
        }
     }
}
