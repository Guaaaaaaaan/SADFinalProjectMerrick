using SADFianlProjectMerrick.Models;
using System.ComponentModel.DataAnnotations;

namespace SADFinalProjectMerrick.Models
{
    public class Notification
    {
        [Key]
        // PK
        public int NotificationId { get; set; }
        public string RecipientEmail { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime SendDate { get; set; }
        public string Status { get; set; }

        // FKs & Reference Navigation Properties
        public int? InvoiceId { get; set; }
        public Invoice Invoice { get; set; }

        public int? ClientId { get; set; }
        public Client Client { get; set; }
    }
}
