using Bussiness.AccesssData;
using System;

namespace tawst1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            DepartmentInfo dp = new DepartmentInfo();
            DoctorInfo doctor = new DoctorInfo();
            //dp.CreatDepartment("asd", "dasd", 5, 5);
            //dp.AddDoctors(1, 5);
            //DoctorInfo doctor = new DoctorInfo();
            //doctor.CreatDoctor("testas","asdsadasdsadasd",50);
            //var rrr = dp.GetDepartmentPatients(2);
            //foreach (var item in rrr)
            //{
            //    Console.WriteLine(item.Id);
            //    Console.WriteLine(item.Name);
            //}
            PatientInfo patient = new PatientInfo();

            doctor.Addpat(5, 5);

            //var dd = doctor.Doctorinfo(2);
            //foreach (var d in dd)
            //{
            //    Console.WriteLine(d.patients.ToString());
            //}
            Console.WriteLine("done");
        }
    }
}
