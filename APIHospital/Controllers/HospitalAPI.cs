using Bussiness.AccesssData;
using FrameworkData.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace APIHospital.Controllers
{
    public class HospitalAPI : Controller
    {
        [Route("[Controller]")]
        [HttpPost]
            public void CreatDepartment(string name, string address)
            {
            var result = new DepartmentInfo();
            result.CreatDepartment(name, address);
            }
        [HttpPost("depaddwithdocpat")]
        public void CreatDepartment(string name, string address,int docNumber, int patNumber)
        {
            var result = new DepartmentInfo();
            result.CreatDepartment(name, address, docNumber, patNumber);
        }

        //[HttpPost("Add Doctor to Department")]
        //public void AddDoctorToDepartment(int depId, int doctorsNum)
        //    {
        //    var result = new DepartmentInfo();
        //    result.AddDoctors(depId, doctorsNum);
        //    }

        [HttpGet("List of Departments")]
        public List<DepartmentModel> GetDepartment()
            {
            DepartmentInfo dep = new DepartmentInfo();
            var result = dep.GetDepartment();
            return result;
            }

        [HttpPost("Creat Doctor")]
        public void CreatDoctor(string name, string address, int age)
            {
            var result = new DoctorInfo();
            result.CreatDoctor(name, address, age);
            }

        [HttpPost("Creat Patient")]
        public void CreatPatient(string name, string address)
        {
            var result = new PatientInfo();
            result.CreatPatient(name, address);
        }
        [HttpPost("Creat Doctor and Patient")]
        public void CreatDoctorAndPatient(string docname, string docaddress, int age, string patname, string patadress)
        {
            var docresult = new DoctorInfo();
            docresult.CreatDoctor(docname, docaddress, age);
            var patresult = new PatientInfo();
            patresult.CreatPatient(patname, patadress);
        }
    }
}
