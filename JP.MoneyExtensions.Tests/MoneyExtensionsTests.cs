namespace JP.MoneyExtensions.Tests;

[TestClass]
public class MoneyExtensionsTests
{
    [TestMethod]
    public void ShouldConvertDecimalToInteger()
    {
        decimal value = 276.47m;
        int result = value.ToCents();

        decimal teste = 0.1m;
        teste.ToCents();

        Assert.AreEqual(27647, result);
    }        
}