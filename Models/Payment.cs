using System.ComponentModel.DataAnnotations;

namespace InsuranceApp.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }

        [Required(ErrorMessage = "Payment type is required.")]
        [StringLength(50, ErrorMessage = "Payment type must be no more than 50 characters.")]
        public string PaymentType { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Amount must be a non-negative value.")]
        public double Amount { get; set; }

        [Required(ErrorMessage = "Date is required.")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Tax must be a non-negative value.")]
        public double Tax { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Total payment must be a non-negative value.")]
        public double TotalPayment { get; set; }

        [Required(ErrorMessage = "Payment status is required.")]
        public bool IsActive { get; set; }

        [Required(ErrorMessage = "Insurance policy is required.")]
        public InsurancePolicy InsurancePolicy { get; set; }
    }
}
