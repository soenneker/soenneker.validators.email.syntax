using EmailValidation;
using Microsoft.Extensions.Logging;
using Soenneker.Validators.Email.Syntax.Abstract;

namespace Soenneker.Validators.Email.Syntax;

///<inheritdoc cref="IEmailSyntaxValidator"/>
public sealed class EmailSyntaxValidator : Validator.Validator, IEmailSyntaxValidator
{
    public EmailSyntaxValidator(ILogger<EmailSyntaxValidator> logger) : base(logger)
    {
    }

    public bool Validate(string email, bool allowInternational = true, bool allowTopLevelDomains = false, bool logOnInvalid = false)
    {
        bool result = EmailValidator.Validate(email, allowTopLevelDomains, allowInternational);

        if (!result && logOnInvalid)
            Logger.LogDebug("Email ({email}) did not pass validation", email);

        return result;
    }
}