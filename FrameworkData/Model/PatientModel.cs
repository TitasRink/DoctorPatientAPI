using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FrameworkData.Model
{
    public class PatientModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("DepartmentModel")]
        public int DepartamentModelId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Lastname { get; set; }
        public string Address { get; set; }
        public List<DoctorModel> doctors { get; set; }

        public PatientModel(string name, string lastname)
        {
            Name = name;
            Lastname = lastname;
        }
    }
}
