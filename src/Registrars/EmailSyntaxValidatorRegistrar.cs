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
    public static void AddEmailSyntaxValidatorAsSingleton(this IServiceCollection services)
    {
        services.TryAddSingleton<IEmailSyntaxValidator, EmailSyntaxValidator>();
    }

    /// <summary>
    /// Adds <see cref="IEmailSyntaxValidator"/> as a scoped service. <para/>
    /// </summary>
    public static void AddEmailSyntaxValidatorAsScoped(this IServiceCollection services)
    {
        services.TryAddScoped<IEmailSyntaxValidator, EmailSyntaxValidator>();
    }
}
