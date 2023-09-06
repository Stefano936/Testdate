namespace TestDateFormat;

public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestCorrectDateFormat()
    {
        string testDate1 = "10/11/1997";
        string dateFormatterTests1 = DateFormatter.ChangeFormat(testDate1);
        string expected = "1997-11-10";
        Assert.AreEqual(dateFormatterTests1,expected);
    }
    public void TestIncorrectDateFormat()
    {
        string testDate2 = "10//21/";
        bool resultado = DateFormatter.CheckFormat(testDate2);
        Assert.False(resultado);
    }
    public void TestEmptyDateFormat()
    {
        string testDate3 = "";
        bool resultado = DateFormatter.CheckFormat(testDate3);
        Assert.False(resultado);
    }
}
