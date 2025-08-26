using Microsoft.Extensions.DependencyInjection;
public static class DependencyInjection
{
    public static IServiceCollection AddPaymentServices(this IServiceCollection services)
    {
        services.AddTransient<IPayment, PayPalPaymentService>();
        services.AddTransient<IPayment, StripePaymentService>();
        return services;
    }

}