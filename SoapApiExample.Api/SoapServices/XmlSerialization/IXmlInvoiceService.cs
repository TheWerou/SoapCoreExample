using SoapApiExample.Api.Model.XmlSerialization;
using System.ServiceModel;

namespace SoapApiExample.Api.SoapServices.XmlSerialization
{
    [ServiceContract]
    public interface IXmlInvoiceService
    {
        [OperationContract]
        public IEnumerable<XmlInvoice> GetServices(GetXmlInvoice invoice);
    }
}
