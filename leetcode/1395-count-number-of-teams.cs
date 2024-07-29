namespace leetcode.s1395;

public class Solution {
    public int NumTeams(int[] rating) {
        int numTeams = 0;
        for (int i = 0; i < rating.Length - 2; i++) {
            for(int j = i + 1; j < rating.Length - 1; j++) {
                for (int k = j + 1; k < rating.Length; k++) {
                    if(rating[i] < rating[j] && rating[j] < rating[k]) {
                        numTeams++;
                    }

                    if(rating[i] > rating[j] && rating[j] > rating[k]) {
                        numTeams++;
                    }
                }
            }
        }

        return numTeams;
    }
}