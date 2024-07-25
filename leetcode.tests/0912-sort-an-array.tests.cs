namespace leetcode.tests.s0912;

using leetcode.s0912;

public class SolutionTest
{
    [Fact]
    public void Test1()
    {
        var soln = new Solution();

        int[] nums = [5,2,3,1];

        int[] actualSortArray = soln.SortArray(nums);

        int[] expectedSortArray = [1,2,3,5];

        Assert.Equal(expectedSortArray, actualSortArray);
    }

    [Fact]
    public void Test2()
    {
        var soln = new Solution();

        int[] nums = [5,1,1,2,0,0];

        int[] actualSortArray = soln.SortArray(nums);

        int[] expectedSortArray = [0,0,1,1,2,5];

        Assert.Equal(expectedSortArray, actualSortArray);
    }
}