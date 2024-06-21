namespace leetcode.s0330;

public class Solution {
    public int MinPatches(int[] nums, int n) {
        int patches = 0;
        long maxSumCovered = 0;
        int i = 0;

        while(maxSumCovered < n) {
            if(i < nums.Length && nums[i] <= maxSumCovered + 1) {
                maxSumCovered += nums[i];
                i++;
            } else {
                maxSumCovered += maxSumCovered + 1;
                patches++;
            }
        }
        return patches;
    }
}


/*
Second Iteration - This didn't work at all. I'm confused by this and I don't understand.
public class Solution {
    public int MinPatches(int[] nums, int n) {
        int addPatchCount = 0;
        var listNums = new List<int>(nums);

        int currentNum = 1;
        var checkList = true;

        while (true) {
            if(checkList == true) {
                // check the list of numbers until we have reached the maximum value in the list
                if(!listNums.Exists(x => x == currentNum)) {
                    listNums.Add(currentNum);
                    listNums.Sort();
                    addPatchCount++;

                    if(listNums.Exists( x =>  x > currentNum && x <= currentNum * 2)) {
                        var indexOfCurrentNum = listNums.IndexOf(currentNum);
                        currentNum = listNums[indexOfCurrentNum + 1];
                    }

                    if(listNums.FindIndex(x => x == currentNum) == listNums.Count -1) {
                        checkList = false;
                    }
                }
            }
            else {
                // double the currentNum until it is >= n
                if(currentNum >= n) {
                    break;
                } else {
                    addPatchCount++;
                }
            }
            currentNum *= 2;
        }

        return addPatchCount;
    }
}
*/

/*First Iteration*/
// public class Solution {
//     public int MinPatches(int[] nums, int n) {
//         int addPatchCount = 0;
//         var listNums = new List<int>(nums);

//         // loop from 1 to n
//         for(int i = 1; i <= n; i++) {
//             long trySum = 0;
//             for(int j = listNums.Count - 1; j >= 0; j--) {
//                 if(trySum + listNums[j] <= i) {
//                     trySum += listNums[j];

//                     if(trySum == i) {
//                         break;
//                     }
//                 }
//             }
//             if(trySum != i) {
//                 if(listNums.Exists(x => x == (i - trySum))) {
//                     listNums.Add(i);
//                     addPatchCount++;
//                 } else {
//                     long temp = (long)i - trySum;

//                     listNums.Add((int)temp);
//                     addPatchCount++;
//                 }
//                 listNums.Sort();
//             }
//         }

//         return addPatchCount;
//     }
// }