using Hospital_Management.Data;
using Hospital_Management.Models;
using Hospital_Management.Repository.Interface;

namespace Hospital_Management.Repository.Implementation
{
    public class DoctorRepository:Repository<Doctor>,IDoctorRepository
       
     {
        private ApplicationDbContext _db;

        public DoctorRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
