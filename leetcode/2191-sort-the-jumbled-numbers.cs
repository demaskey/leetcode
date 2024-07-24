namespace leetcode.s2191;

public class Solution {
    public int[] SortJumbled(int[] mapping, int[] nums) {

        int[] numsValues = new int[nums.Length];
        // translate nums to values
        for(int i = 0; i < nums.Length; i++) {
            int num = nums[i];
            int numValue = 0;

            if(num == 0) {
                numValue = mapping[num];
            } else {
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
            }

            numsValues[i] = numValue;
        }

        var listNumsValues = new List<int>(numsValues);
        listNumsValues.Sort();

        int[] arrangedNums = new int[nums.Length];
        for(int i = 0; i < arrangedNums.Length; i++) {
            arrangedNums[i] = -1;
        }

        for (int i = 0; i < nums.Length; i++) {
            int index = listNumsValues.IndexOf(numsValues[i]);

            while(arrangedNums[index] != -1) {
                index++;
            }
            
            arrangedNums[index] = nums[i];
        }


        return arrangedNums;
    }
}