using leetcode.s0826;

namespace leetcode.tests.s0826;

public class SolutionTest
{
    [Fact]
    public void Test1()
    {
        var soln = new Solution();

        int[] difficulty = [2,4,6,8,10];
        int[] profit = [10,20,30,40,50];
        int[] worker = [4,5,6,7];

        int maxProfits = soln.MaxProfitAssignment(difficulty, profit, worker);

        Assert.Equal(100, maxProfits);
    }

    [Fact]
    public void Test2()
    {
        var soln = new Solution();

        int[] difficulty = [85,47,57];
        int[] profit = [24,66,99];
        int[] worker = [40,25,25];

        int maxProfits = soln.MaxProfitAssignment(difficulty, profit, worker);

        Assert.Equal(0, maxProfits);
    }
}
