using Hospital_Management.Models;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Hospital_Management.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Doctor> Doctors { get; set; }// table er registration kori 
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Billing> Billings { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
    }
}
