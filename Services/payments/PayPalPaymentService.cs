class PayPalPaymentService : IPaymentService
{
    public string Name => "PayPal";

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
