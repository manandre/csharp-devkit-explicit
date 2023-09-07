namespace NUnitTests;

 [TestFixture]
public class NUnitTests
{
    [Test]
    public void TestTruth()
    {
        Assert.That(true, Is.True);
    }

    [Test]
    public void TestFalsehood()
    {
        Assert.That(false, Is.False);
    }

    [Test, Explicit]
    public void TestExplicit()
    {
        Assert.Pass("Always passes if you run it!");
    }

    [OneTimeTearDown]
    public void OneTimeTearDown()
    {
        TestContext context = TestContext.CurrentContext;
        Assert.That(context.Result, Is.Not.Null);
        Assert.That(context.Result.PassCount, Is.EqualTo(2));
        Assert.That(context.Result.FailCount, Is.EqualTo(0));
        Assert.That(context.Result.SkipCount, Is.EqualTo(1));
    }
}