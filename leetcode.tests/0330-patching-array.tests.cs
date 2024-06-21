using leetcode.s0330;

namespace leetcode.tests.s0330;

public class SolutionTest
{
    [Fact]
    public void Test1()
    {
        var soln = new Solution();

        int[] nums = [1,3];
        int n = 6;

        int actual = soln.MinPatches(nums, n);

        int expected = 1;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test2()
    {
        var soln = new Solution();

        int[] nums = [1,5,10];
        int n = 20;

        int actual = soln.MinPatches(nums, n);

        int expected = 2;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test3()
    {
        var soln = new Solution();

        int[] nums = [1,2,2];
        int n = 5;

        int actual = soln.MinPatches(nums, n);

        int expected = 0;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test4()
    {
        var soln = new Solution();

        int[] nums = [1,2,31,33];
        int n = 2147483647;

        int actual = soln.MinPatches(nums, n);

        int expected = 28;

        Assert.Equal(expected, actual);
    }
}
