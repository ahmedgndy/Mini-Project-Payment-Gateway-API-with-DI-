
var builder = WebApplication.CreateBuilder(args);

//registration the services 
builder.Services.AddPaymentServices();


var app = builder.Build();

app.MapPost("/Payment", (IPaymentService payment ) =>
{
   var result = payment.PaymentProcess(100);
    return Results.Ok(result);

});

app.Run();



