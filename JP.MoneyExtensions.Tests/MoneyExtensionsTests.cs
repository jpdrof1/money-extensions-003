namespace JP.MoneyExtensions.Tests;

[TestClass]
public class MoneyExtensionsTests
{
    [TestMethod]
    public void ShouldConvertDecimalToInteger()
    {
        decimal value = 276.47m;
        int result = value.ToCents();

        Assert.AreEqual(27647, result);
    }
}