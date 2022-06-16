using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FrameworkData.Model
{
    public class DoctorModel
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("DepartamentModel")]
        public int DepartamentModelId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Speciality { get; set; }
        [Required]
        public int Age { get; set; }
        public List<PatientModel> patients { get; set; }
    }
}
