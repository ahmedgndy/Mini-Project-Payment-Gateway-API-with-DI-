using PaymentGatewayApi.Models;

class PayPalPaymentService : IPaymentService
{
    public string Name => "PayPal";

    public PaymentResponse PaymentProcess(PaymentRequest request)
    {
        // Implement PayPal payment processing logic here
        return new PaymentResponse
        {
            Status = "Success",
            Provider = Name,
            Amount = request.Amount,
            TransactionId = Guid.NewGuid().ToString(),
            Message = "Payment processed successfully."
        };
    }
}

     

