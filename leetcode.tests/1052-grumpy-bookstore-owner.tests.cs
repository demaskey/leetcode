namespace leetcode.tests.s1052;

using leetcode.s1052;

public class SolutionTest
{
    [Fact]
    public void Test1()
    {
        var soln = new Solution();

        int[] customers = [1,0,1,2,1,1,7,5];
        int[] grumpy = [0,1,0,1,0,1,0,1];
        int minutes = 3;

        int actualMaxSatisfied = soln.MaxSatisfied(customers, grumpy, minutes);

        int expectedMaxSatisfied = 16;

        Assert.Equal(expectedMaxSatisfied, actualMaxSatisfied);
    }

    [Fact]
    public void Test2()
    {
        var soln = new Solution();

        int[] customers = [1];
        int[] grumpy = [0];
        int minutes = 1;

        int actualMaxSatisfied = soln.MaxSatisfied(customers, grumpy, minutes);

        int expectedMaxSatisfied = 1;

        Assert.Equal(expectedMaxSatisfied, actualMaxSatisfied);
    }
}