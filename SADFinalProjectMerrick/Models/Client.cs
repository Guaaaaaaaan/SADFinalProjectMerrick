using SADFinalProjectMerrick.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SADFianlProjectMerrick.Models
{
    public class Client
    {
        [Key]
        // PK
        public int ClientId { get; set; }

        // FK (与 User 的 One-to-One 关系)
        public int UserId { get; set; }

        public string Name { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }


        // Collection Navigation Properties (与 Invoice, Notification 的 1-to-Many 关系)
        public ICollection<Invoice> Invoices { get; set; }
        public ICollection<Notification> Notifications { get; set; }
    }
}
