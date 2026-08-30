[![](https://img.shields.io/nuget/v/Soenneker.Validators.Email.Syntax.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Validators.Email.Syntax/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.validators.email.syntax/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.validators.email.syntax/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/Soenneker.Validators.Email.Syntax.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Validators.Email.Syntax/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.validators.email.syntax/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.validators.email.syntax/actions/workflows/codeql.yml)

# Soenneker.Validators.Email.Syntax

Checks email-address syntax through the `EmailValidation` parser, with controls for international addresses and top-level domains.

## Install

```bash
dotnet add package Soenneker.Validators.Email.Syntax
```

## Registration

```csharp
using Soenneker.Validators.Email.Syntax.Registrars;
using Microsoft.Extensions.DependencyInjection;

services.AddEmailSyntaxValidatorAsSingleton();
```

The validator is stateless. Singleton registration is appropriate for most applications; `AddEmailSyntaxValidatorAsScoped()` is also available.

## Usage

```csharp
using Soenneker.Validators.Email.Syntax.Abstract;

bool valid = validator.Validate("person@example.com");
```

Defaults are:

- `allowInternational: true`
- `allowTopLevelDomains: false`
- `logOnInvalid: false`

Enable top-level-domain addresses when inputs such as `postmaster@dk` should be accepted:

```csharp
bool valid = validator.Validate(
    "postmaster@dk",
    allowInternational: true,
    allowTopLevelDomains: true);
```

Set `allowInternational: false` when international characters in the address should be rejected.

## Failure and logging behavior

Invalid syntax returns `false`. A null input throws `ArgumentNullException` from the underlying parser.

When `logOnInvalid` is true, the full rejected email address is written at debug level. Email addresses are personal data in many environments; keep this disabled unless that log content is acceptable and protected.

Syntax validation does not prove that the domain exists, publishes mail records, that the mailbox exists, or that the address belongs to the user. Combine it with the appropriate domain checks and verification flow for those requirements.
