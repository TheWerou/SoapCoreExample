using System.Runtime.Serialization;

namespace SoapApiExample.Api.Model.DataContract
{
    [DataContract]
    public class Invoice
    {
        [DataMember]
        public required int InvoiceNumber { get; set; }
        [DataMember]
        public required string CustomerName { get; set; }
        [DataMember]
        public required DateTime InvoiceDate { get; set; }
        [DataMember]
        public ICollection<InvoiceItem> Items { get; set; } = new List<InvoiceItem>();
    }
}
