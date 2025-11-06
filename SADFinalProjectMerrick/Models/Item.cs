using SADFianlProjectMerrick.Models;
namespace SADFinalProjectMerrick.Models
{
    public class Item
    {// PK
        public int ItemId { get; set; }
        public string Description { get; set; }
        public double UnitPrice { get; set; }

        // ICollection
        public ICollection<InvoiceItem> InvoiceItems { get; set; }
    }
}
