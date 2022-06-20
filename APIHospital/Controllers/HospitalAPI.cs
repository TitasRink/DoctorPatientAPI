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
        [HttpPost("Creat dep with doc and pat")]
        public void CreatDepartment(string depName, string depAddress,int docNumber, int patNumber)
            {
            var result = new DepartmentInfo();
            result.CreatDepartment(depName, depAddress, docNumber, patNumber);
            }

        [HttpPost("Add Doctor to Department")]
        public void AddDoctorToDepartment(int depId, int doctorsNum)
            {
            var result = new DoctorInfo();
            result.AddToDepartment(depId, doctorsNum);
            }

        [HttpGet("List of Departments")]
        public List<DepartmentModel> GetDepartment()
            {
            DepartmentInfo dep = new DepartmentInfo();
            var result = dep.GetDepartment();
            return result;
            }

        [HttpPost("Creat Doctor")]
        public void CreatDoctor(string name, string address, int age, int depId)
            {
            var result = new DoctorInfo();
            result.CreatDoctor(name, address, age, depId);
            }

        [HttpPost("Creat Patient")]
        public void CreatPatient(string name, string address)
            {
            var result = new PatientInfo();
            result.CreatPatient(name, address);
            }

        [HttpGet("List of Department-Doctors")]
        public List<DoctorModel> GetDoctors(int departmentID)
            {
            DoctorInfo dep = new DoctorInfo();
            var result = dep.GetDepartmentDoctors(departmentID);
            return result;
            }
        //[HttpGet("List of Department-Patients")]
        //public List<PatientModel> GetPatients(int departmentID)
        //    {
        //    PatientInfo dep = new PatientInfo();
        //    var result = dep.GetDepartmentPatients(departmentID);
        //    return result;
        //    }

        [HttpPost("Add Patient to Doctor")]
        public void AddPatient(int docNum, int patNum)
        {
            var result = new DoctorInfo();
            result.Addpat(docNum, patNum);
        }
        
        [HttpGet("List Patient by Doctor ID")]
        public List<DoctorModel> GetPatientListFromDoctor(int departmentID)
        {
            DoctorInfo dep = new DoctorInfo();
            var result = dep.Doctorinfo(departmentID);
            return result;
        }
    }
}
