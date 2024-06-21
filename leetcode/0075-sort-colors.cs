namespace leetcode.s0075;

/*
Given an array nums with n objects colored red, white, or blue, sort them in-place so that objects of the same color are adjacent, with the colors in the order red, white, and blue.

We will use the integers 0, 1, and 2 to represent the color red, white, and blue, respectively.

You must solve this problem without using the library's sort function.

 

Example 1:

Input: nums = [2,0,2,1,1,0]
Output: [0,0,1,1,2,2]
Example 2:

Input: nums = [2,0,1]
Output: [0,1,2]
 

Constraints:

n == nums.length
1 <= n <= 300
nums[i] is either 0, 1, or 2.
 

Follow up: Could you come up with a one-pass algorithm using only constant extra space?
*/

public class Solution {
    public void SortColors(int[] nums) {
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] == 0)
            {
                // move to index 0
                int j = 0;

                while (j < i)
                {
                    if(nums[j] != 0) {
                        int temp1 = nums[i];
                        int temp2 = nums[j];
                        nums[i] = temp2;
                        nums[j] = temp1;
                        i--; // recheck the new value in nums[i]
                        break;
                    } else {
                        j++;
                    }
                }
            }
            else if(nums[i] == 2)
            {
                // move to index nums.Length - 1
                int j = nums.Length - 1;

                while (j > i)
                {
                    if(nums[j] != 2) {
                        int temp1 = nums[i];
                        int temp2 = nums[j];
                        nums[i] = temp2;
                        nums[j] = temp1;
                        i--; // recheck the new value in nums[i]
                        break;
                    }
                    else {
                        j--;
                    }
                }
            }
            else
            {
                // skip over because it's a 1 and they should all stay in the middle
                continue;
            }
        }
    }
}