using Microsoft.Extensions.DependencyInjection;
public static class DependencyInjection
{
    public static IServiceCollection AddPaymentServices(this IServiceCollection services)
    {
        services.AddTransient<IPaymentService<PayPalPaymentService>, PayPalPaymentService>();
        services.AddTransient<IPaymentService<StripePaymentService>, StripePaymentService>();
        return services;
    }

}