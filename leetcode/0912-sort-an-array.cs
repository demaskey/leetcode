using System.Data;

namespace leetcode.s0912;

public class Solution {
    public int[] SortArray(int[] nums) {
        if(nums.Length == 1) {
            return nums;
        } else {
            // divide array in half
            int half = nums.Length / 2;
            int[] firstHalf = new int[half];
            int[] secondHalf = new int[nums.Length - half];

            // copy first half into new array
            for (int i = 0; i < firstHalf.Length; i++) {
                firstHalf[i] = nums[i];
            }

            // copy second half
            for (int i = 0; i < secondHalf.Length; i++) {
                secondHalf[i] = nums[i + half];
            }

            firstHalf = SortArray(firstHalf);
            secondHalf = SortArray(secondHalf);

            // merge first and second half
            int[] mergedArray = new int[firstHalf.Length + secondHalf.Length];
            int firstHalfIndex = 0;
            int secondHalfIndex = 0;
            for(int i = 0; i < mergedArray.Length; i++) {
                // don't have any more items in first half
                if(firstHalfIndex == firstHalf.Length && secondHalfIndex < secondHalf.Length) {
                    // pick next number in second half
                    mergedArray[i] = secondHalf[secondHalfIndex];
                    secondHalfIndex++;
                } else if (secondHalfIndex == secondHalf.Length && firstHalfIndex < firstHalf.Length) {
                    // pick next number in the first half array
                    mergedArray[i] = firstHalf[firstHalfIndex];
                    firstHalfIndex++;
                } else {
                    // which is smaller
                    if(firstHalf[firstHalfIndex] < secondHalf[secondHalfIndex]) {
                        mergedArray[i] = firstHalf[firstHalfIndex];
                        firstHalfIndex++;
                    } else {
                        mergedArray[i] = secondHalf[secondHalfIndex];
                        secondHalfIndex++;
                    }
                }
            }

            return mergedArray;
        }
    }
}