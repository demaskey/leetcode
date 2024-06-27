namespace leetcode.s1791;

public class Solution {
    public int FindCenter(int[][] edges) {
        int center = -1;

        /*I think this is cheating but let's see what happens...*/

        int temp1 = edges[0][0];
        int temp2 = edges[0][1];
        int temp3 = edges[1][0];
        int temp4 = edges[1][1];

        if(temp1 == temp3 || temp1 == temp4) {
            center = temp1;
        } else if(temp2 == temp3 || temp2 == temp4) {
            center = temp2;
        }

        return center;       
    }

    /* This is my first iteration of the solution but on test 58 it failed on LeetCode with a Time Limit  Exceeeded error.
    public int FindCenter(int[][] edges) {
        int center = -1;
    
        // how many edges are there?
        // parse every edge and figure out which value occurs the same number as the edges
        var listEdgeNodes = new List<EdgeNode>();

        for (int i = 0; i < edges.Length; i++) {
            for(int j = 0; j < 2; j++) {
                if(listEdgeNodes.Exists(x => x.val == edges[i][j])) {
                    int index = listEdgeNodes.FindIndex(x => x.val == edges[i][j]);
                    listEdgeNodes[index].occuranceCount++;
                } else {
                    var newEdgeNode = new EdgeNode(edges[i][j]);
                    newEdgeNode.occuranceCount++;
                    listEdgeNodes.Add(newEdgeNode);
                }
            }
        }

        center = listEdgeNodes.Find(x => x.occuranceCount == edges.Length).val;
        

        return center;       
    }
    */
}

public class EdgeNode{
    public int val;
    public int occuranceCount;

    public EdgeNode(int val){
        this.val = val;
        this.occuranceCount = 0;
    }
}