using SADFinalProjectMerrick.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SADFianlProjectMerrick.Models
{
    public class Invoice
    {
        // Primary Key (PK)
        [Key]
        // PK
        public int InvoiceId { get; set; }
        public string InvoiceNumber { get; set; }

        // FK
        public int ClientId { get; set; }

        public DateTime IssueDate { get; set; }
        public DateTime DueDate { get; set; }
        public double TotalAmount { get; set; }
        public double TaxAmount { get; set; }
        public string Status { get; set; }

        // Reference Navigation Property
        public Client Client { get; set; }


        // ICollection
        public ICollection<InvoiceItem> InvoiceItems { get; set; }
        public ICollection<Payment> Payments { get; set; }
        public ICollection<Notification> Notifications { get; set; }
    }
}
