namespace leetcode.tests.s1530;

using leetcode.s1530;

public class SolutionTests()
{
    [Fact]
    public void Test1()
    {
        // Given
        var soln = new Solution();
        TreeNode root = new TreeNode(1, new TreeNode(2,null,new TreeNode(4)),new TreeNode(3));
        int distance = 3;
        // When
        var actualResponse = soln.CountPairs(root, distance);

        var expectedResponse = 1;
        // Then
        Assert.Equal(expectedResponse, actualResponse);
    }

    [Fact]
    public void Test2()
    {
        // Given
        var soln = new Solution();
        TreeNode root = new TreeNode(1,new TreeNode(2,new TreeNode(4),new TreeNode(5)),new TreeNode(3,new TreeNode(6), new TreeNode(7)));
        int distance = 3;
        // When
        var actualResponse = soln.CountPairs(root, distance);

        var expectedResponse = 2;
        // Then
        Assert.Equal(expectedResponse, actualResponse);
    }

    [Fact]
    public void Test3()
    {
        // Given
        var soln = new Solution();
        TreeNode root = new TreeNode(7,new TreeNode(1, new TreeNode(6)), new TreeNode(4, new TreeNode(5), new TreeNode(3,null,new TreeNode(2))));
        int distance = 3;
        // When
        var actualResponse = soln.CountPairs(root, distance);

        var expectedResponse = 1;
        // Then
        Assert.Equal(expectedResponse, actualResponse);
    }
}