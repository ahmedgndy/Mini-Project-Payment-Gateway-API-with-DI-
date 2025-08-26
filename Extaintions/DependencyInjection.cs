using Microsoft.Extensions.DependencyInjection;
public static class DependencyInjection
{
    public static IServiceCollection AddPaymentServices(this IServiceCollection services)
    {
        services.AddTransient<IPaymentService, PayPalPaymentService>();
        services.AddTransient<IPaymentService, StripePaymentService>();
        return services;
    }

}