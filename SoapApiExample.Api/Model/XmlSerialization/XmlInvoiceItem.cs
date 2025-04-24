using System.Xml.Serialization;

namespace SoapApiExample.Api.Model.XmlSerialization
{
    [XmlType]
    public class XmlInvoiceItem
    {
        [XmlElement]
        public string? Description { get; set; }
        [XmlElement]
        public required int Quantity { get; set; }
        [XmlElement]
        public required decimal UnitPrice { get; set; }
    }
}
