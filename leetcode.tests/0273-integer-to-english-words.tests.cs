namespace leetcode.tests.s0273;

using leetcode.s0273;

public class SolutionTests
{
    [Fact]
    public void Test1()
    {
        var soln = new Solution();

        int num = 123;

        string actualNumberToWords = soln.NumberToWords(num);

        string expectedNumberToWords = "One Hundred Twenty Three";

        Assert.Equal(expectedNumberToWords, actualNumberToWords);
    }

    [Fact]
    public void Test2()
    {
        var soln = new Solution();

        int num = 12345;

        string actualNumberToWords = soln.NumberToWords(num);

        string expectedNumberToWords = "Twelve Thousand Three Hundred Forty Five";

        Assert.Equal(expectedNumberToWords, actualNumberToWords);
    }

    [Fact]
    public void Test3()
    {
        var soln = new Solution();

        int num = 1234567;

        string actualNumberToWords = soln.NumberToWords(num);

        string expectedNumberToWords = "One Million Two Hundred Thirty Four Thousand Five Hundred Sixty Seven";

        Assert.Equal(expectedNumberToWords, actualNumberToWords);
    }

    [Fact]
    public void Test4()
    {
        var soln = new Solution();

        int num = 8;

        string actualNumberToWords = soln.NumberToWords(num);

        string expectedNumberToWords = "Eight";

        Assert.Equal(expectedNumberToWords, actualNumberToWords);
    }

    [Fact]
    public void Test5()
    {
        var soln = new Solution();

        int num = 18;

        string actualNumberToWords = soln.NumberToWords(num);

        string expectedNumberToWords = "Eighteen";

        Assert.Equal(expectedNumberToWords, actualNumberToWords);
    }

    [Fact]
    public void Test6()
    {
        var soln = new Solution();

        int num = 79;

        string actualNumberToWords = soln.NumberToWords(num);

        string expectedNumberToWords = "Seventy Nine";

        Assert.Equal(expectedNumberToWords,actualNumberToWords);
    }

    [Fact]
    public void Test7()
    {
        var soln = new Solution();

        int num = 0;

        string actualNumberToWords = soln.NumberToWords(num);

        string expectedNumberToWords = "Zero";

        Assert.Equal(expectedNumberToWords,actualNumberToWords);
    }
}