using Microsoft.EntityFrameworkCore;

namespace MVCEFApp.Models
{
    public class HospitalDbContext : DbContext
    {
        public DbSet<Doctor>   Doctors { get; set; }    
        public DbSet<Patient> Patients { get; set; }    
        public DbSet<Appointment> Appointments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            String conString = @"server=200411LTP2851\SQLEXPRESS;database=HospitaDB;integrated security=true;Encrypt=false;";
            optionsBuilder.UseSqlServer(conString);
        }
    }
}
