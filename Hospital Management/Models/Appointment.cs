using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hospital_Management.Models
{
    public class Appointment
    {
        [Key] // Primary Key
        public int AppointmentID { get; set; }

        [Required]
        [ForeignKey("Doctor")]
        public int DoctorID { get; set; }

        [Required]
        [ForeignKey("Patient")]
        public int PatientID { get; set; }

        [Required]
        public DateTime AppointmentDate { get; set; }

        [StringLength(255)]
        public string Reason { get; set; }

        [StringLength(50)]
        public string Status { get; set; } // Scheduled, Completed, Canceled

        // Navigation Properties
        //public virtual Doctor Doctor { get; set; }
        //public virtual Patient Patient { get; set; }
        //public virtual Billing Billing { get; set; }
    }
}
