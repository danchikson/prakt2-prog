using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class SolutionTests
{
    private Solution _solution;

    [TestInitialize]
    public void Setup()
    {
        _solution = new Solution();
    }

    [TestMethod]
    public void GcdOfStrings_WhenStringsAreEqual_ReturnsFullString()
    {
        string str1 = "ABC";
        string str2 = "ABC";
        string expected = "ABC";

        string result = _solution.GcdOfStrings(str1, str2);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void GcdOfStrings_WhenNoCommonDivisor_ReturnsEmptyString()
    {
        string str1 = "ABCD";
        string str2 = "EFGH";
        string expected = "";

        string result = _solution.GcdOfStrings(str1, str2);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void GcdOfStrings_WhenStringsHaveCommonDivisor_ReturnsGcd()
    {
        string str1 = "ABABAB";
        string str2 = "ABAB";
        string expected = "AB";

        string result = _solution.GcdOfStrings(str1, str2);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void GcdOfStrings_WhenOneStringEmpty_ReturnsEmptyString()
    {
        string str1 = "ABC";
        string str2 = "";
        string expected = "";

        string result = _solution.GcdOfStrings(str1, str2);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void GcdOfStrings_WhenBothStringsEmpty_ReturnsEmptyString()
    {
        string str1 = "";
        string str2 = "";
        string expected = "";

        string result = _solution.GcdOfStrings(str1, str2);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void GcdOfStrings_WhenLongerCommonDivisor_ReturnsLongestGcd()
    {
        string str1 = "ABCABCABC";
        string str2 = "ABCABC";
        string expected = "ABC";

        string result = _solution.GcdOfStrings(str1, str2);

        Assert.AreEqual(expected, result);
    }
}

