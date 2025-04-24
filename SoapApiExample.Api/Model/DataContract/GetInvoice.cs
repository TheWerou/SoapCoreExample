using System.Runtime.Serialization;

namespace SoapApiExample.Api.Model.DataContract
{
    [DataContract]
    public class GetInvoice
    {
        [DataMember]
        public required int InvoiceNumber { get; set; }
    }
}
