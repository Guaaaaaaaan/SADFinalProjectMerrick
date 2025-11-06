using SADFianlProjectMerrick.Models;
using System.ComponentModel.DataAnnotations;

namespace SADFinalProjectMerrick.Models
{
    public class Report
    {
        [Key]
        // PK
        public int ReportId { get; set; }
        public string Type { get; set; }

        // FK (指向 FinanceStaff.StaffId)
        public int GeneratedBy { get; set; }

        public DateTime GeneratedDate { get; set; }
        public string Format { get; set; }

        // Reference Navigation Property
        public FinanceStaff Generator { get; set; }
    }
}
