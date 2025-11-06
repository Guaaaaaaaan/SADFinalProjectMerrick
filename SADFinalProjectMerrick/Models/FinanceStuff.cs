using SADFianlProjectMerrick.Models;
using SADFinalProjectMerrick.Models;
using System.ComponentModel.DataAnnotations;

namespace SADFianlProjectMerrick.Models
{
    public class FinanceStaff
    {
        [Key]
        public int StaffId { get; set; }

        // FK (与 User 的 One-to-One 关系)
        public int UserId { get; set; }

        public string Department { get; set; }

        // Collection Navigation Properties (与 Report 的 1-to-Many 关系)
        public ICollection<Report> GeneratedReports { get; set; }
    }
}
