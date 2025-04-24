using SoapApiExample.Api.Model.XmlSerialization;
using System.Xml;
using System.Xml.Serialization;

namespace SoapApiExample.Api.SoapServices.Encoded
{
    public class EndocedInvoiceService : IEndocedInvoiceService
    {
        public string GetServices(string input)
        {
            var xsSubmit = new XmlSerializer(typeof(IEnumerable<XmlInvoice>));
            var list = new List<XmlInvoice>()
            {
                new XmlInvoice()
                {
                    CustomerName = "Jhon",
                    InvoiceDate = DateTime.Now,
                    InvoiceNumber = 1,
                    Items = [
                        new XmlInvoiceItem()
                        {
                            Description = "Pen",
                            Quantity = 1,
                            UnitPrice = 21.37M
                        }
                    ]
                },
                new XmlInvoice()
                {
                    CustomerName = "Tom",
                    InvoiceDate = DateTime.Now,
                    InvoiceNumber = 1,
                    Items = [
                        new XmlInvoiceItem()
                        {
                            Description = "Cars",
                            Quantity = 1,
                            UnitPrice = 22.12M
                        }
                    ]
                }
            };

            using (var sww = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sww))
                {
                    xsSubmit.Serialize(writer, list);
                    return sww.ToString(); 
                }
            }
        }
    }
}
