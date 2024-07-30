using System.Runtime.CompilerServices;

namespace leetcode.s1653;

public class Solution {
    public int MinimumDeletions(string s) {
        int n = s.Length;
        
        // Arrays to store the minimum deletions required
        int[] leftBs = new int[n];
        int[] rightAs = new int[n];
        
        // Initialize the leftBs and rightAs counts
        leftBs[0] = s[0] == 'b' ? 1 : 0;
        rightAs[n - 1] = s[n - 1] == 'a' ? 1 : 0;

        // Fill the leftBs array (cumulative deletions needed to make s[0:i] balanced)
        for (int i = 1; i < n; i++) {
            leftBs[i] = leftBs[i - 1] + (s[i] == 'b' ? 1 : 0);
        }

        // Fill the rightAs array (cumulative deletions needed to make s[i:n] balanced)
        for (int i = n - 2; i >= 0; i--) {
            rightAs[i] = rightAs[i + 1] + (s[i] == 'a' ? 1 : 0);
        }

        // Calculate the minimum deletions required if you removed all a's or b's
        int minDeletions = Math.Min(leftBs[n - 1], rightAs[0]);
        for (int i = 0; i < n - 1; i++) {
            // Find out if there is a combination of removing b's on the left and a's on the right that is smaller than removing all a's or b's
            minDeletions = Math.Min(minDeletions, leftBs[i] + rightAs[i + 1]);
        }

        return minDeletions;
    }
}

public class FirstPassSolution {
    public int MinimumDeletions(string s) {
        int minimumDeleteions = 0;

        while(!IsBalanced(s)) {
            // remove leading 'b's
            if(s[0] == 'b') {
                while(s[0] == 'b') {
                    s = s.Remove(0,1);
                    minimumDeleteions++;
                }
            } else {
                int lastIndexOfA = s.LastIndexOf('a');
                s = s.Remove(lastIndexOfA,1);

                minimumDeleteions++;
            }
        }
        return minimumDeleteions;
    }

    private bool IsBalanced(string s) {
        for(int i = 0; i < s.Length; i++) {
            for(int j = i + 1; j < s.Length; j++) {
                if(s[i] == 'b' && s[j] == 'a') {
                    return false;
                }
            }
        }
        return true;
    }
}