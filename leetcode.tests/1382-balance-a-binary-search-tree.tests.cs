namespace leetcode.tests.s1382;

using System.Diagnostics.CodeAnalysis;
using leetcode.s1382;

public class SolutionTest
{
    [Fact]
    public void Test1()
    {
        var soln = new Solution();

        // [1,null,2,null,3,null,4]
        var root = new TreeNode(1, null, new TreeNode(2, null, new TreeNode(3, null, new TreeNode(4))));

        var actualBalancedBST = soln.BalanceBST(root);

        var expectedBSTCollection = new List<TreeNode>();
        expectedBSTCollection.Add(new TreeNode(2, new TreeNode(1), new TreeNode(3, null, new TreeNode(4))));
        expectedBSTCollection.Add(new TreeNode(3, new TreeNode(1, null, new TreeNode(2)), new TreeNode(4)));

        Assert.Contains(actualBalancedBST, expectedBSTCollection, new TreeNodeEqualityComparer());

    }

    [Fact]
    public void Test2()
    {
        var soln = new Solution();

        // [2,1,3]
        var root = new TreeNode(2, new TreeNode(1), new TreeNode(3));

        var actualBalancedBST = soln.BalanceBST(root);

        var expectedBalancedBST = new TreeNode(2, new TreeNode(1), new TreeNode(3));;

        Assert.Equal(expectedBalancedBST, actualBalancedBST, new TreeNodeEqualityComparer());
    }
}

public class TreeNodeEqualityComparer : IEqualityComparer<TreeNode>
{
    public bool Equals(TreeNode? x, TreeNode? y)
    {
        if(ReferenceEquals(x, y))
            return true;

        if(x is null || y is null)
            return false;

        return x.val == y.val && Equals(x.left, y.left) && Equals(x.right, y.right);
    }

    public int GetHashCode([DisallowNull] TreeNode obj)
    {
        throw new NotImplementedException();
    }
}