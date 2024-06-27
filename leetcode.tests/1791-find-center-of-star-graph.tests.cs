namespace leetcode.tests.s1791;

using leetcode.s1791;

public class SolutionTest
{
    [Fact]
    public void Test1()
    {
        var soln = new Solution();

        int[][] edges = [[1,2],[2,3],[4,2]];

        int expectedCenter = 2;

        int actualCenter = soln.FindCenter(edges);

        Assert.Equal(expectedCenter, actualCenter);
    }

    [Fact]
    public void Test2()
    {
        var soln = new Solution();

        int[][] edges = [[1,2],[5,1],[1,3],[1,4]];

        int expectedCenter = 1;

        int actualCenter = soln.FindCenter(edges);

        Assert.Equal(expectedCenter, actualCenter);
    }

    // this test is so big that I can't run it on my machine. I'm going to comment out for now.
    // [Fact]
    // public void Test3()
    // {
    //     var soln = new Solution();    
        
    
    //     int expectedCenter = 32;

    //     int actualCenter = soln.FindCenter(edges);

    //     Assert.Equal(expectedCenter, actualCenter);
    // }
}