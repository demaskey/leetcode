namespace leetcode.s1550;

public class Solution {
    public bool ThreeConsecutiveOdds(int[] arr) {
        int count = 0;

        foreach(int item in arr) {
            if(item % 2 == 1) {
                count++;
            } else {
                count = 0;
            }

            if(count == 3) {
                return true;
            }
        }

        return false;
    }
}