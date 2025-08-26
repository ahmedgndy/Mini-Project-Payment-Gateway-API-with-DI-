using PaymentGatewayApi.Models;

class StripePaymentService : IPaymentService
{
    public string Name => "Stripe";

    public PaymentResponse PaymentProcess(PaymentRequest request)
    {
        // Implement Stripe payment processing logic here
        return new PaymentResponse
        {
            Status = "Success",
            Provider = Name,
            Amount = request.Amount,
            TransactionId = Guid.NewGuid().ToString(),
            Message = "Payment processed successfully."
        };
    }
};