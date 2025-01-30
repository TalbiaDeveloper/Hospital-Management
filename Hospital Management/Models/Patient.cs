using System.ComponentModel.DataAnnotations;

namespace Hospital_Management.Models
{
    public class Patient
    {

        [Key] // Primary Key
        public int PatientID { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        [StringLength(10)]
        public string Gender { get; set; }

        [StringLength(15)]
        public string ContactNumber { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        // Navigation Property
        //public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
