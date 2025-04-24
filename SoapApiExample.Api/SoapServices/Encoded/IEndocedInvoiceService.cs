using SoapApiExample.Api.Model.XmlSerialization;
using System.ServiceModel;

namespace SoapApiExample.Api.SoapServices.Encoded
{
    [ServiceContract]
    public interface IEndocedInvoiceService
    {
        [OperationContract]
        public string GetServices(string input);
    }
}
