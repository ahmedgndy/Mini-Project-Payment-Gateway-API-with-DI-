class StripePaymentService : IPaymentService
{
    public string Name => "Stripe";

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
