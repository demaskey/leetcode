namespace leetcode.tests.s1395;

using leetcode.s1395;

public class SolutionTest
{
    [Fact]
    public void Test1()
    {
        var soln = new Solution();

        int[] rating = [2,5,3,4,1];

        int actualNumTeams = soln.NumTeams(rating);

        int expectedNumTeams = 3;

        Assert.Equal(expectedNumTeams, actualNumTeams);
    }

    [Fact]
    public void Test2()
    {
        var soln = new Solution();

        int[] rating = [2,1,3];

        int actualNumTeams = soln.NumTeams(rating);

        int expectedNumTeams = 0;

        Assert.Equal(expectedNumTeams, actualNumTeams);
    }

    [Fact]
    public void Test3()
    {
        var soln = new Solution();

        int[] rating = [1,2,3,4];

        int actualNumTeams = soln.NumTeams(rating);

        int expectedNumTeams = 4;

        Assert.Equal(expectedNumTeams, actualNumTeams);
    }

    [Fact]
    public void Test4()
    {
        var soln = new Solution();

        int[] rating = [3,6,7,5,1];

        int actualNumTeams = soln.NumTeams(rating);

        int expectedNumTeams = 3;

        Assert.Equal(expectedNumTeams, actualNumTeams);
    }
}