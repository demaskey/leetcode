using System.Runtime.InteropServices;

namespace leetcode.s1382;

public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution()
{
    public TreeNode BalanceBST(TreeNode root) {
        TreeNode balancedTree = null;

        int leftCount = CountNodes(root.left);
        int rightCount = CountNodes(root.right);

        if(Math.Abs(leftCount - rightCount) <= 1) {
            balancedTree = root;
        } else {
            int[] nodeValues = GetNodeValues(root);
        }

        return balancedTree;
    }

    private int[] GetNodeValues(TreeNode tree) {
        var nodeValues = new List<int>();

        return nodeValues.ToArray();
    }

    private int CountNodes (TreeNode root) {
        // count the root as a node
        int count = 0;

        if(root != null) {
            count = 1;

            if(root.left != null) {
                count += CountNodes (root.left);
            }

            if(root.right != null) {
                count += CountNodes (root.right);
            }
        }

        return count;
    }
}