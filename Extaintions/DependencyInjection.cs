using Microsoft.Extensions.DependencyInjection;
public static class DependencyInjection
{
    public static IServiceCollection AddPaymentServices(this IServiceCollection services, IHostEnvironment env)
    {


        services.AddTransient<IPaymentService, FakePaymentService>();

        services.AddScoped<IPaymentService, PayPalPaymentService>();
        services.AddSingleton<IPaymentService, StripePaymentService>();

        
        services.AddTransient<ITransientService, PayPalPaymentService>();
        services.AddSingleton<ISingletonService, StripePaymentService>();





        //factory 
        services.AddTransient<IPaymentFactory, PaymentFactory>();


        return services;

    }

}
