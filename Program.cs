
var builder = WebApplication.CreateBuilder(args);

//registration the services 
builder.Services.AddPaymentServices();


var app = builder.Build();

app.MapPost("/paypal", ( IPaymentService  payPalPaymentService) =>
{

    return payPalPaymentService.PaymentProcess(100);
});

app.MapPost("/stripe", ( IPaymentService stripePaymentService) =>
{

    return stripePaymentService.PaymentProcess(100);
});



app.Run();



