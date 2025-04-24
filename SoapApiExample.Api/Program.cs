using SoapApiExample.Api.SoapServices.DataContract;
using SoapApiExample.Api.SoapServices.Encoded;
using SoapApiExample.Api.SoapServices.XmlSerialization;
using SoapCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSoapCore();
builder.Services.AddSingleton<IInvoiceService, InvoiceService>();
builder.Services.AddSingleton<IXmlInvoiceService, XmlInvoiceService>();
builder.Services.AddSingleton<IEndocedInvoiceService, EndocedInvoiceService>();

var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoints => {
    _ = endpoints.UseSoapEndpoint<IXmlInvoiceService>(opt =>
    {
        opt.Path = "/XmlServicePath.asmx";
        opt.SoapSerializer = SoapSerializer.XmlSerializer;
    });
    _ = endpoints.UseSoapEndpoint<IEndocedInvoiceService>(opt =>
    {
        opt.Path = "/EndocedServicePath.asmx";
        opt.SoapSerializer = SoapSerializer.XmlSerializer;
    });
    _ = endpoints.UseSoapEndpoint<IInvoiceService>(opt =>
    {
        opt.Path = "/ServicePath.asmx";
        opt.SoapSerializer = SoapSerializer.DataContractSerializer;
    });
});

app.Run();
