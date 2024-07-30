namespace leetcode.tests.s1653;

using leetcode.s1653;

public class SolutionTest
{
    [Fact]
    public void Test1()
    {
        var soln = new Solution();
        
        string s = "aababbab";

        int actualMinimumDeletions = soln.MinimumDeletions(s);

        int expectedMaximumDeletions = 2;

        Assert.Equal(expectedMaximumDeletions, actualMinimumDeletions);
    }

    [Fact]
    public void Test2()
    {
        var soln = new Solution();
        
        string s = "bbaaaaabb";

        int actualMinimumDeletions = soln.MinimumDeletions(s);

        int expectedMaximumDeletions = 2;

        Assert.Equal(expectedMaximumDeletions, actualMinimumDeletions);
    }

    [Fact]
    public void Test3()
    {
        var soln = new Solution();
        
        string s = "aaaabab";

        int actualMinimumDeletions = soln.MinimumDeletions(s);

        int expectedMaximumDeletions = 1;

        Assert.Equal(expectedMaximumDeletions, actualMinimumDeletions);
    }

    [Fact]
    public void Test4()
    {
        var soln = new Solution();
        
        string s = "bbbbb";

        int actualMinimumDeletions = soln.MinimumDeletions(s);

        int expectedMaximumDeletions = 0;

        Assert.Equal(expectedMaximumDeletions, actualMinimumDeletions);
    }

    [Fact]
    public void Test5()
    {
        var soln = new Solution();
        
        string s = "baababbaabbaaabaabbabbbabaaaaaabaabababaaababbb";

        int actualMinimumDeletions = soln.MinimumDeletions(s);

        int expectedMaximumDeletions = 18;

        Assert.Equal(expectedMaximumDeletions, actualMinimumDeletions);
    }
}