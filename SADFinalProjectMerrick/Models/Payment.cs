using SADFianlProjectMerrick.Models;
using System.ComponentModel.DataAnnotations;

namespace SADFinalProjectMerrick.Models
{
    public class Payment
    {
        [Key]
        // PK
        public int PaymentId { get; set; }

        // FK
        public int InvoiceId { get; set; }

        public DateTime PaymentDate { get; set; }
        public double Amount { get; set; }
        public string Method { get; set; }
        public string TransactionId { get; set; }
        public string Status { get; set; }

        // Reference Navigation Property (Invoice)
        public Invoice Invoice { get; set; }

        // FK & Reference Navigation Property (PaymentGateway)
        public string GatewayName { get; set; }
        public PaymentGateway PaymentGateway { get; set; }
    }
}
