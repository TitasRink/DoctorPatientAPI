using FrameworkData.Model;
using Microsoft.EntityFrameworkCore;

namespace FrameworkData.DataContext
{
    public class DataConection : DbContext
    {
        public DbSet<DepartmentModel> Departments { get; set; }
        public DbSet<DoctorModel> Doctors { get; set; }
        public DbSet<PatientModel> Patients { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=localhost;Database=Hospital;Trusted_Connection=True;");
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Client>()
        //        .HasOne(i => i.Restaurant)
        //        .WithMany(i => i.Clients)
        //        .IsRequired()
        //        .OnDelete(DeleteBehavior.NoAction);
        //}
    }
}
