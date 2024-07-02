namespace leetcode.tests.s0350;

using leetcode.s0350;

public class SolutionTest
{
    [Fact]
    public void Test1()
    {
        var soln = new Solution();

        int[] nums1 = [1,2,2,1];
        int[] nums2 = [2,2];

        var actualIntersection = soln.Intersect(nums1, nums2);

        int[] expectedIntersection  = [2,2];

        Assert.Equal(expectedIntersection, actualIntersection);
    }

    [Fact]
    public void Test2()
    {
        var soln = new Solution();

        int[] nums1 = [4,9,5];
        int[] nums2 = [9,4,9,8,4];

        var actualIntersection = soln.Intersect(nums1, nums2);

        int[] expectedIntersection  = [4,9];

        Assert.Equal(expectedIntersection, actualIntersection);
    }
}