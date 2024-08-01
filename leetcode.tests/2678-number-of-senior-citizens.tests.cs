namespace leetcode.tests.s2678;

using leetcode.s2678;

public class SolutionTests
{
    [Fact]
    public void Test1()
    {
        var soln = new Solution();

        string[] details = ["7868190130M7522","5303914400F9211","9273338290F4010"];

        int actualCountSeniors = soln.CountSeniors(details);

        int expectedCountSeniors = 2;

        Assert.Equal(expectedCountSeniors, actualCountSeniors);
    }

    [Fact]
    public void Test2()
    {
        var soln = new Solution();

        string[] details = ["1313579440F2036","2921522980M5644"];

        int actualCountSeniors = soln.CountSeniors(details);

        int expectedCountSeniors = 0;

        Assert.Equal(expectedCountSeniors, actualCountSeniors);
    }
}