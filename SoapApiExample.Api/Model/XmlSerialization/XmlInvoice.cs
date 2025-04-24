using System.Xml.Serialization;

namespace SoapApiExample.Api.Model.XmlSerialization
{
    [XmlType]
    public class XmlInvoice
    {
        [XmlElement]
        public required int InvoiceNumber { get; set; }
        [XmlElement]
        public required string CustomerName { get; set; }
        [XmlElement]
        public required DateTime InvoiceDate { get; set; }
        [XmlElement]
        public ICollection<XmlInvoiceItem> Items { get; set; } = new List<XmlInvoiceItem>();
    }
}
