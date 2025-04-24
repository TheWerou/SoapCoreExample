using SoapApiExample.Api.Model.DataContract;

namespace SoapApiExample.Api.SoapServices.DataContract
{
    public class InvoiceService : IInvoiceService
    {
        public IEnumerable<Invoice> GetInvoices(GetInvoice invoice)
        {
            return [
                new Invoice()
                {
                    CustomerName = "Jhon",
                    InvoiceDate = DateTime.Now,
                    InvoiceNumber = 1,
                    Items = [
                        new InvoiceItem()
                        {
                            Description = "Pen",
                            Quantity = 1,
                            UnitPrice = 21.37M
                        }
                    ]
                },
                new Invoice()
                {
                    CustomerName = "Tom",
                    InvoiceDate = DateTime.Now,
                    InvoiceNumber = 1,
                    Items = [
                        new InvoiceItem()
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
