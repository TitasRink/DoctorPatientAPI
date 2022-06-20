namespace FrameworkData.Model
{
    public class DoctorModel
    {
        public int Id { get; set; }
<<<<<<< Updated upstream
        public int DepartamentID { get; set; }
=======
        [Required]
>>>>>>> Stashed changes
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Speciality { get; set; }
        public int Age { get; set; }
<<<<<<< Updated upstream
=======
        public int DepartmentModelId { get; set; }
        public List<PatientModel> patients { get; set; }

        public DoctorModel(string name, string lastName, int age)
        {
            Name = name;
            LastName = lastName;
            Age = age;
            patients = new List<PatientModel>();
        }
>>>>>>> Stashed changes
    }
}
