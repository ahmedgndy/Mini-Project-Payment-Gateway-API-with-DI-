using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

//registration the services 
builder.Services.AddPaymentServices();


var app = builder.Build();

app.MapPost("/Payment", ([FromServices]IPayment payment ) =>
{
   var result = payment.PaymentProcess(100);
    return Results.Ok(result);

});

app.Run();

interface IPayment
{
   Dictionary<string, string > PaymentProcess(decimal amount);
}

class PayPalPaymentService : IPayment
{
   public Dictionary<string, string > PaymentProcess(decimal amount)
   {
       return new Dictionary<string, string>
       {
           {"Status", "Success"},
           {"Amount", amount.ToString()},
           {"PaymentMethod", "PayPal"}
       };
   }
}

class StripePaymentService : IPayment
{
   public Dictionary<string, string > PaymentProcess(decimal amount)
   {
       return new Dictionary<string, string>
       {
           {"Status", "Success"},
           {"Amount", amount.ToString()},
           {"PaymentMethod", "strips"}
       };
   }
}
