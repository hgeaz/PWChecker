using PwChecker;

namespace PwCheckerTests;

[TestClass]
public sealed class Tester
{
    [TestMethod]
    public void Password_TooShort_ReturnsError()
    {
        var checker = new PasswordChecker("Abc!123");
            
        var result = checker.GetStrength();
            
        Assert.AreEqual("Password is too short.", result);
    }

    [TestMethod]
    public void Password_TooLong_ReturnsError()
    {
        var checker = new PasswordChecker("Abcdefghijklmnop!123");
            
        var result = checker.GetStrength();
            
        Assert.AreEqual("Password is too long.", result);
    }

    [TestMethod]
    public void Password_MissingSpecialCharacter_ReturnsError()
    {
        var checker = new PasswordChecker("Abcdefgh1234");
            
        var result = checker.GetStrength();
            
        Assert.AreEqual("Password Needs at least one special character - !@#$%^&*()", result);
    }

    [TestMethod]
    public void Password_MissingNumber_ReturnsError()
    {
        var checker = new PasswordChecker("Abcdefghijkl!");
            
        var result = checker.GetStrength();
            
        Assert.AreEqual("Password needs at least one number!", result);
    }

    [TestMethod]
    public void Password_Valid_ReturnsSuccess()
    {
        var checker = new PasswordChecker("Abcdefgh12!2");
            
        var result = checker.GetStrength();
            
        Assert.AreEqual("Great password!", result);
    }
}