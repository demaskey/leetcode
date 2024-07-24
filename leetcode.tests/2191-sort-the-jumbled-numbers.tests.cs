namespace leetcode.tests.s2191;

using leetcode.s2191;

public class SolutionTest
{
    [Fact]
    public void Test1()
    {
        var soln = new Solution();

        int[] mapping  = [8,9,4,0,2,1,3,5,7,6];
        int[] nums = [991,338,38];

        int[] actualSortJumbled = soln.SortJumbled(mapping, nums);

        int[] expectedSortJumbled = [338,38,991];

        Assert.Equal(expectedSortJumbled, actualSortJumbled);
    }

    [Fact]
    public void Test2()
    {
        var soln = new Solution();

        int[] mapping  = [0,1,2,3,4,5,6,7,8,9];
        int[] nums = [789,456,123];

        int[] actualSortJumbled = soln.SortJumbled(mapping, nums);

        int[] expectedSortJumbled = [123,456,789];

        Assert.Equal(expectedSortJumbled, actualSortJumbled);
    }

    [Fact]
    public void Test3()
    {
        var soln = new Solution();

        int[] mapping  = [9,8,7,6,5,4,3,2,1,0];
        int[] nums = [0,1,2,3,4,5,6,7,8,9];

        int[] actualSortJumbled = soln.SortJumbled(mapping, nums);

        int[] expectedSortJumbled = [9,8,7,6,5,4,3,2,1,0];

        Assert.Equal(expectedSortJumbled, actualSortJumbled);
    }
}