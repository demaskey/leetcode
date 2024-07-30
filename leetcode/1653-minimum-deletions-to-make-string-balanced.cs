using System.Runtime.CompilerServices;

namespace leetcode.s1653;

public class Solution {
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