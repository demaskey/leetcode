namespace leetcode.tests.s1105;

using leetcode.s1105;

public class SolutionTests
{
    [Fact]
    public void Test1()
    {
        var soln = new Solution();

        int[][] books = [[1,1],[2,3],[2,3],[1,1],[1,1],[1,1],[1,2]];
        int shelfWidth = 4;

        int actualMinHeightShelves = soln.MinHeightShelves(books, shelfWidth);

        int expectedMinHeightShelves = 6;

        Assert.Equal(expectedMinHeightShelves, actualMinHeightShelves);
    }

    [Fact]
    public void Test2()
    {
        var soln = new Solution();

        int[][] books = [[1,3],[2,4],[3,2]];
        int shelfWidth = 6;

        int actualMinHeightShelves = soln.MinHeightShelves(books, shelfWidth);

        int expectedMinHeightShelves = 4;

        Assert.Equal(expectedMinHeightShelves, actualMinHeightShelves);
    }
}