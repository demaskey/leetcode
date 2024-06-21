namespace leetcode.s0945;

public class Solution {
    public int MinIncrementForUnique(int[] nums) {
        Array.Sort(nums);

        int increments = 0;
        for (int i = 1; i < nums.Length; i++) {
            if(nums[i] <= nums[i - 1]) {
                int incrment = nums[i - 1] - nums[i] + 1;
                nums[i] += incrment;
                increments += incrment;
            }
        }

        return increments;
    }
}