using FrameworkData.Model;
using Microsoft.EntityFrameworkCore;

namespace FrameworkData.DataContext
{
    public class DataConection : DbContext
    {
        public DbSet<DepartmentModel> Departments { get; set; }
        public DbSet<DoctorModel> Doctors { get; set; }
        public DbSet<PatientModel> Patients { get; set; }
        public override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=localhost;Database=Hospital;Trusted_Connection=True;");
        }
    }
}
