namespace leetcode.s0502;

public class Solution {
    /*
    This function executes and it solves the problem. Unfortunately, when the 
    profits and capital arrays are very large then it fails because the timelimit exceeeded.*/

    // public int FindMaximizedCapital(int k, int w, int[] profits, int[] capital) {
    //     int output = w;

    //     for (int projectsToDo = 0; projectsToDo < k; projectsToDo++) {
    //         int projectIndexToChoose = -1;

    //         for(int i = 0; i < capital.Length; i++) {
    //             if(capital[i] <= w) {
    //                 if(projectIndexToChoose == -1) {
    //                     projectIndexToChoose = i;
    //                 } else if(profits[i] > profits[projectIndexToChoose]) {
    //                     projectIndexToChoose = i;
    //                 }
    //             }
    //         }

    //         if(projectIndexToChoose != -1) {
    //             // update capital with profits
    //             output += profits[projectIndexToChoose];
    //             w += profits[projectIndexToChoose];

    //             // remove projectIndexToChoose from profits and capital
    //             var profitsToCheck = new List<int>(profits);
    //             profitsToCheck.RemoveAt(projectIndexToChoose);
    //             profits = profitsToCheck.ToArray();
    //             var capitalToCheck = new List<int>(capital);
    //             capitalToCheck.RemoveAt(projectIndexToChoose);
    //             capital = capitalToCheck.ToArray();
    //         }
    //     }

    //     return output;
    // }
    

    /*
    I don't fully understand how this one works yet... I want and need to come 
    back to it...*/
    
    public int FindMaximizedCapital(int k, int w, int[] profits, int[] capital) {
        var minHeap = new PriorityQueue<int, int>();
        var maxHeap = new PriorityQueue<int,int>();

        for(int i = 0; i < profits.Length; i++) {
            minHeap.Enqueue(profits[i], capital[i]);
        }

        for (int i = 0; i < k; i++) {
            while(minHeap.TryPeek(out int projectProfit, out int projectCost) && projectCost <= w) {
                maxHeap.Enqueue(projectProfit, -projectProfit);
                minHeap.Dequeue();
            }

            if(maxHeap.TryDequeue(out int maxProfit, out _)) {
                w += maxProfit;
            } else {
                break;
            }
        }
        return w;
    }
}