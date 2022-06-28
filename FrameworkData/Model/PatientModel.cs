using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FrameworkData.Model
{
    public class PatientModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Lastname { get; set; }
        public string Address { get; set; }
        public DoctorModel doctor { get; set; }

        public PatientModel(string name, string lastname)
        {
            Name = name;
            Lastname = lastname;
            
        }
    }
}
