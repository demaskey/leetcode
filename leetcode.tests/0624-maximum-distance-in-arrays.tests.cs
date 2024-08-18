namespace leetcode.tests.s0624;

using leetcode.s0624;

public class SolutionTests
{
    [Fact]
    public void Test1()
    {
        var soln = new Solution();

        IList<IList<int>> arrays = [[1,2,3],[4,5],[1,2,3]];

        int actualMaxDistance = soln.MaxDistance(arrays);

        int expectedMaxDistance = 4;

        Assert.Equal(expectedMaxDistance,actualMaxDistance);
    }

    [Fact]
    public void Test2()
    {
        var soln = new Solution();

        IList<IList<int>> arrays = [[1],[1]];

        int actualMaxDistance = soln.MaxDistance(arrays);

        int expectedMaxDistance = 0;

        Assert.Equal(expectedMaxDistance,actualMaxDistance);
    }

    [Fact]
    public void Test3()
    {
        var soln = new Solution();

        IList<IList<int>> arrays = [[1,4],[0,5]];

        int actualMaxDistance = soln.MaxDistance(arrays);

        int expectedMaxDistance = 4;

        Assert.Equal(expectedMaxDistance,actualMaxDistance);
    }

    [Fact]
    public void Test4()
    {
        var soln = new Solution();

        IList<IList<int>> arrays = [[1,5],[3,4]];

        int actualMaxDistance = soln.MaxDistance(arrays);

        int expectedMaxDistance = 3;

        Assert.Equal(expectedMaxDistance,actualMaxDistance);
    }
}