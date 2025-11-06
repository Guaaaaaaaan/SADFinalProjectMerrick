using SADFianlProjectMerrick.Models;
using System.ComponentModel.DataAnnotations;

namespace SADFinalProjectMerrick.Models
{
    public class InvoiceItem
    {
        // FKs
        public int ItemId { get; set; }
        public int InvoiceId { get; set; }

        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double Total { get; set; }

        // Reference Navigation Properties
        public Invoice Invoice { get; set; }
        public Item Item { get; set; }
    }
}
