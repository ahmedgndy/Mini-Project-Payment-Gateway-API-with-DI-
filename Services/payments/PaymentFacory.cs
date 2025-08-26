

public interface IPaymentFactory
{
    IPaymentService GetService(string provider);
}

public class PaymentFactory : IPaymentFactory
{
    private readonly IEnumerable<IPaymentService> _service;
    public PaymentFactory(IEnumerable<IPaymentService> services)
    {
        _service = services;
    }
    public IPaymentService GetService(string provider)
    {
        var service = _service.FirstOrDefault( s =>
            s.Name.Equals(provider, StringComparison.OrdinalIgnoreCase)
        );
        
        if (service == null)
        {
            throw new NotImplementedException();
        }
        return service;
    }
}