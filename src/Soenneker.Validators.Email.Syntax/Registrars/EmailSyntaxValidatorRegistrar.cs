using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.Validators.Email.Syntax.Abstract;

namespace Soenneker.Validators.Email.Syntax.Registrars;

/// <summary>
/// A validation module checking if a given email's domain is disposable/temporary, updated daily (if available)
/// </summary>
public static class EmailSyntaxValidatorRegistrar
{
    /// <summary>
    /// Adds <see cref="IEmailSyntaxValidator"/> as a singleton service.
    /// </summary>
    /// <param name="services">Service collection that receives the registration.</param>
    /// <returns>The same service collection, so additional registrations can be chained.</returns>
    public static IServiceCollection AddEmailSyntaxValidatorAsSingleton(this IServiceCollection services)
    {
        services.TryAddSingleton<IEmailSyntaxValidator, EmailSyntaxValidator>();

        return services;
    }

    /// <summary>
    /// Adds <see cref="IEmailSyntaxValidator"/> as a scoped service. <para/>
    /// </summary>
    /// <param name="services">Service collection that receives the registration.</param>
    /// <returns>The same service collection, so additional registrations can be chained.</returns>
    public static IServiceCollection AddEmailSyntaxValidatorAsScoped(this IServiceCollection services)
    {
        services.TryAddScoped<IEmailSyntaxValidator, EmailSyntaxValidator>();

        return services;
    }
}
