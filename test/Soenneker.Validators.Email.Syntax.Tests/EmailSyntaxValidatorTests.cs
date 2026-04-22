using Soenneker.Validators.Email.Syntax.Abstract;
using Soenneker.Tests.HostedUnit;


namespace Soenneker.Validators.Email.Syntax.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class EmailSyntaxValidatorTests : HostedUnitTest
{
    private readonly IEmailSyntaxValidator _util;

    public EmailSyntaxValidatorTests(Host host) : base(host)
    {
        _util = Resolve<IEmailSyntaxValidator>(true);
    }

    [Test]
    public void Default()
    {

    }
}
