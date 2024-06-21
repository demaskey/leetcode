namespace leetcode.s0826;

public class Solution {
    public int MaxProfitAssignment(int[] difficulty, int[] profit, int[] worker) {
        int maxProfits = 0;

        for(int w = 0; w < worker.Length; w++) {
            int profitForWorker = 0;
            for(int d = 0; d < difficulty.Length; d++) {
                if(worker[w] >= difficulty[d]) {
                    if(profitForWorker < profit[d]) {
                        profitForWorker = profit[d];
                    }
                }
            }

            maxProfits += profitForWorker;
        }

        return maxProfits;
    }
}
