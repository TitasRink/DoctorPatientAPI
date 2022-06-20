using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkData.Model
{
    public class PatientModel
    {
        public int Id { get; set; }
<<<<<<< Updated upstream
=======
        [Required]
>>>>>>> Stashed changes
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
<<<<<<< Updated upstream
=======
        public int DepartmentModelId { get; set; }
        public List<DoctorModel> doctors { get; set; }

        public PatientModel(string name, string lastname)
        {
            Name = name;
            Lastname = lastname;
            doctors = new List<DoctorModel>();
        }
>>>>>>> Stashed changes
    }
}
