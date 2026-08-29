[![](https://img.shields.io/nuget/v/Soenneker.Validators.Email.Syntax.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Validators.Email.Syntax/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.validators.email.syntax/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.validators.email.syntax/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/Soenneker.Validators.Email.Syntax.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Validators.Email.Syntax/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.validators.email.syntax/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.validators.email.syntax/actions/workflows/codeql.yml)

# Soenneker.Validators.Email.Syntax

A validation module for checking email syntax.

## Install

```bash
dotnet add package Soenneker.Validators.Email.Syntax
```

## Quick start

```csharp
using Soenneker.Validators.Email.Syntax.Registrars;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
var result = services.AddEmailSyntaxValidatorAsSingleton();
```

Adds `IEmailSyntaxValidator` as a singleton service.

## What you get

- `IEmailSyntaxValidator` — A validation module for checking email syntax.
- `EmailSyntaxValidatorRegistrar` — A validation module checking if a given email's domain is disposable/temporary, updated daily (if available).

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `IEmailSyntaxValidator.Validate(email, allowInternational, allowTopLevelDomains, logOnInvalid)` | Validate the specified email address for syntax. | `true` if the email address is valid; otherwise, `false`. |
| `EmailSyntaxValidatorRegistrar.AddEmailSyntaxValidatorAsSingleton(services)` | Adds `IEmailSyntaxValidator` as a singleton service. | The same service collection, so additional registrations can be chained. |
| `EmailSyntaxValidatorRegistrar.AddEmailSyntaxValidatorAsScoped(services)` | Adds `IEmailSyntaxValidator` as a scoped service. | The same service collection, so additional registrations can be chained. |

## Important behavior

- `IEmailSyntaxValidator.Validate(email, allowInternational, allowTopLevelDomains, logOnInvalid)`: Validates the syntax of an email address. If `allowInternational` is `true`, then the validator will use the newer International Email standards for validating the email address.
- `IEmailSyntaxValidator.Validate(email, allowInternational, allowTopLevelDomains, logOnInvalid)`: `email` is `null`.
