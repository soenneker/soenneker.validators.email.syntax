using Soenneker.Validators.Email.Syntax.Abstract;
using Soenneker.Tests.FixturedUnit;
using Xunit;


namespace Soenneker.Validators.Email.Syntax.Tests;

[Collection("Collection")]
public class EmailSyntaxValidatorTests : FixturedUnitTest
{
    private readonly IEmailSyntaxValidator _util;

    public EmailSyntaxValidatorTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _util = Resolve<IEmailSyntaxValidator>(true);
    }

    [Fact]
    public void Default()
    {

    }
}
