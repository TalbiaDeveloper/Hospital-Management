using System.ComponentModel.DataAnnotations;

namespace Hospital_Management.Models
{
    public class Doctor
    {
        [Key] // Primary Key
        public int DoctorID { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(100)]
        public string Specialty { get; set; }

        [StringLength(15)]
        public string ContactNumber { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(255)]
        public string OfficeAddress { get; set; }

        // Navigation Property
        //public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
