using SoapApiExample.Api.Model.DataContract;
using System.ServiceModel;

namespace SoapApiExample.Api.SoapServices.DataContract
{
    [ServiceContract]
    public interface IInvoiceService
    {
        [OperationContract]
        public IEnumerable<Invoice> GetInvoices(GetInvoice invoice);
    }
}
