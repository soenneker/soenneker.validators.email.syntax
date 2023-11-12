using Soenneker.Validators.Validator.Abstract;

namespace Soenneker.Validators.Email.Syntax.Abstract;

/// <summary>
/// A validation module for checking email syntax
/// </summary>
public interface IEmailSyntaxValidator : IValidator
{
    /// <summary>
    /// Validate the specified email address for syntax.
    /// </summary>
    /// <remarks>
    /// <para>Validates the syntax of an email address.</para>
    /// <para>If <paramref name="allowInternational"/> is <c>true</c>, then the validator
    /// will use the newer International Email standards for validating the email address.</para>
    /// </remarks>
    /// <para>If <paramref name="allowTopLevelDomains"/> is <c>true</c>, then the validator will
    /// allow addresses with top-level domains like <c>postmaster@dk</c>.</para>
    /// <returns><c>true</c> if the email address is valid; otherwise, <c>false</c>.</returns>
    /// <param name="email">An email address.</param>
    /// <param name="allowInternational"><c>true</c> if the validator should allow international characters; otherwise, <c>false</c>.</param>
    /// <param name="allowTopLevelDomains"><c>true</c> if the validator should allow addresses at top-level domains; otherwise, <c>false</c>.</param>
    /// <param name="logOnInvalid"></param>
    /// <exception cref="System.ArgumentNullException">
    /// <paramref name="email"/> is <c>null</c>.
    /// </exception>
    public bool Validate(string email, bool allowInternational = true, bool allowTopLevelDomains = false, bool logOnInvalid = false);
}