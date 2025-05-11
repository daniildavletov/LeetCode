using Problems;

namespace Tests;

public class Tests
{
    private ValidParentheses validParentheses;
    
    [SetUp]
    public void Setup()
    {
        validParentheses = new ValidParentheses();
    }

    [Test]
    public void IsValid_ForTwoOpen_False()
    {
        string s = "{{";

        var isValid = validParentheses.IsValid(s);
        
        Assert.That(isValid, Is.False);
    }

    [Test] public void IsValid_ForTwoClose_False()
    {
        string s = "))";

        var isValid = validParentheses.IsValid(s);
        
        Assert.That(isValid, Is.False);
    }
}