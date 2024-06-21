using leetcode.s0075;

namespace leetcode.tests.s0075;

public class SolutionTest
{
    [Fact]
    public void Test1()
    {
        var soln = new Solution();

        int[] nums = [2,0,2,1,1,0];

        soln.SortColors(nums);

        int[] expected = [0,0,1,1,2,2];

        Assert.Equal(expected, nums);
    }

    [Fact]
    public void Test2()
    {
        var soln = new Solution();

        int[] nums = [2,0,1];

        soln.SortColors(nums);

        int[] expected = [0,1,2];

        Assert.Equal(expected, nums);
    }
}
