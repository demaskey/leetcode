using System.Data;
using System.Security.Cryptography;

namespace leetcode.s1530;

public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left = null, TreeNode right = null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution {
    public int CountPairs(TreeNode root, int distance) {
        int answer = 0;
        DepthFirstSearch(root, distance, ref answer);
        return answer;
    }

    private List<int> DepthFirstSearch(TreeNode node, int distance, ref int answers){
        if(node == null) {
            return new List<int>();
        }
        if(node.left == null && node.right == null) {
            return new List<int>{ 0 };
        }

        var leftDistances = DepthFirstSearch(node.left, distance, ref answers);
        var rightDistances = DepthFirstSearch(node.right, distance, ref answers);

        foreach(int left in leftDistances) {
            foreach(int right in rightDistances) {
                if(left + right + 2 <= distance) {
                    answers++;
                }
            }
        }

        var distances = new List<int>();
        foreach(int left in leftDistances) {
            distances.Add(left + 1);
        }
        foreach(int right in rightDistances) {
            distances.Add(right + 1);
        }

        return distances;
    }
}