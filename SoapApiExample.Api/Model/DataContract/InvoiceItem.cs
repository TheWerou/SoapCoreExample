using System.Runtime.Serialization;

namespace SoapApiExample.Api.Model.DataContract
{
    [DataContract]
    public class InvoiceItem
    {
        [DataMember]
        public string? Description { get; set; }
        [DataMember]
        public required int Quantity { get; set; }
        [DataMember]
        public required decimal UnitPrice { get; set; }
    }
}
