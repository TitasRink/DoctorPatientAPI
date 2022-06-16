using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        [Required]
        public string Address { get; set; }
        [Required]
        public List<DoctorModel> doctors { get; set; }
        public PatientModel(string name, string lastname)
        {
            Name = name;
            Lastname = lastname;
        }
    }
}
