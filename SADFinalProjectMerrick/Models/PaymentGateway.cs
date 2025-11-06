using SADFianlProjectMerrick.Models;
namespace SADFinalProjectMerrick.Models
{
    public class PaymentGateway
    {
        // PK
        public string GatewayName { get; set; }

        public string ApiKey { get; set; }

        // ICollection
        public ICollection<Payment> Payments { get; set; }
    }
}
