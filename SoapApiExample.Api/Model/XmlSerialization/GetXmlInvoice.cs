using System.Xml.Serialization;

namespace SoapApiExample.Api.Model.XmlSerialization
{
    [XmlType]
    public class GetXmlInvoice
    {
        [XmlElement]
        public required int InvoiceNumber { get; set; }
    }
}
