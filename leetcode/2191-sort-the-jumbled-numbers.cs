namespace leetcode.s2191;

public class Solution {
    public int[] SortJumbled(int[] mapping, int[] nums) {

        int[] numsValues = new int[nums.Length];
        // translate nums to values
        for(int i = 0; i < nums.Length; i++) {
            int num = nums[i];
            int numValue = 0;

            int power = 0;
            while(num > 0){
                int remainder = num % 10;

                // set up for the next iteration
                num -= remainder; 
                num /= 10;

                // perform mapping
                numValue += mapping[remainder] * (int)Math.Pow(10, power);

                // increase power
                power++;
            }

            numsValues[i] = numValue;
        }

        var listNumsValues = new List<int>(numsValues);
        listNumsValues.Sort();


        return listNumsValues.ToArray();
    }
}