using SoapApiExample.Api.Model.XmlSerialization;

namespace SoapApiExample.Api.SoapServices.XmlSerialization
{
    public class XmlInvoiceService : IXmlInvoiceService
    {
        public IEnumerable<XmlInvoice> GetServices(GetXmlInvoice invoice)
        {
            return [
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
            ];
        }
    }
}
