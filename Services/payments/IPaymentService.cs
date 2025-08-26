
public interface IPaymentService
{
   Dictionary<string, string> PaymentProcess(decimal amount);
   string Name { get; }
}