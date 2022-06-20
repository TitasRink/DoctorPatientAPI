using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FrameworkData.Model
{
    public class PatientModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public int DepartmentModelId { get; set; }
        public List<DoctorModel> doctors { get; set; }

        public PatientModel(string name, string lastname)
        {
            Name = name;
            Lastname = lastname;
            doctors = new List<DoctorModel>();
        }
    }
}
