using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hospital_Management.Models
{
    public class Billing
    {
        [Key] // Primary Key
        public int BillingID { get; set; }

        [Required]
        [ForeignKey("Appointment")]
        public int AppointmentID { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Amount { get; set; }

        [StringLength(50)]
        public string PaymentStatus { get; set; } // Paid, Unpaid, Pending

        public DateTime? PaymentDate { get; set; }

        [StringLength(50)]
        public string PaymentMethod { get; set; } // Cash, Credit Card, Insurance

        // Navigation Property
        //public virtual Appointment Appointment { get; set; }
    }
}
