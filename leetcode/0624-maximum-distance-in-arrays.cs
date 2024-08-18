using System.Collections.Immutable;

namespace leetcode.s0624;

public class Solution {
    public int MaxDistance(IList<IList<int>> arrays) {
        int n = arrays.Count;

        // Initialize to extreme opposite values
        int minGlobal = int.MaxValue;
        int maxGlobal = int.MinValue;

        int result = 0;

        // Loop to find global min and max excluding current array
        for (int i = 0; i < n; i++) {
            int currentMin = arrays[i][0];
            int currentMax = arrays[i][arrays[i].Count - 1];

            // Calculate maximum distance for this array
            if (i > 0) {
                result = Math.Max(result, Math.Abs(currentMax - minGlobal));
                result = Math.Max(result, Math.Abs(maxGlobal - currentMin));
            }

            // Update global min and max
            minGlobal = Math.Min(minGlobal, currentMin);
            maxGlobal = Math.Max(maxGlobal, currentMax);
        }

        return result;
    }

    public int MaxDistance_SecondTry(IList<IList<int>> arrays) {
        Dictionary<int,int> IndexAndLargestValue = new Dictionary<int,int>();
        Dictionary<int,int> IndexAndSmallestValue =  new Dictionary<int, int>();

        for(int m = 0; m < arrays.Count; m++) {
            IList<int> tempArray = arrays[m];
            IndexAndLargestValue.Add(m, tempArray[tempArray.Count - 1]);
            IndexAndSmallestValue.Add(m, tempArray[0]);
        }

        var largest = IndexAndLargestValue.ToImmutableSortedDictionary();
        var smallest = IndexAndSmallestValue.ToImmutableSortedDictionary();

        int largestValue, smallestValue;

        if(largest.Last().Key != smallest.First().Key) {
            largestValue = largest.Last().Value;
            smallestValue = smallest.First().Value;
        } else {
            largestValue = 0;
            smallestValue = smallest.First().Value;
        }

        return Math.Abs(largestValue - smallestValue);
    }

    public int MaxDistance_FirstTry(IList<IList<int>> arrays) {
        int indexOfArrayWithLargestValue = GetIndexOfArrayWithLargestNumber(arrays);

        int indexOfArrayWithSmallestValue = GetIndexOfArrayWithSmallestNumber(arrays, indexOfArrayWithLargestValue);
        
        int maxDistance = Math.Abs(arrays[indexOfArrayWithLargestValue][arrays[indexOfArrayWithLargestValue].Count - 1] - arrays[indexOfArrayWithSmallestValue][0]);
        
        return maxDistance;
    }

    private int GetIndexOfArrayWithLargestNumber(IList<IList<int>> arrays) {
        int index = 0;
        int largestValue = Math.Abs(arrays[index][arrays[index].Count - 1]);

        for (int m = 0; m < arrays.Count; m++){
            int tempValue = Math.Abs(arrays[m][arrays[m].Count - 1]);
            if(largestValue < tempValue) {
                largestValue = tempValue;
                index = m;
            }
        }

        return index;
    }

    private int GetIndexOfArrayWithSmallestNumber(IList<IList<int>> arrays, int indexOfUsedArray) {
        int index = 0;
        if(index == indexOfUsedArray) {
            index = 1;
        }
        int smallestValue = Math.Abs(arrays[index][0]);

        for (int m = 0; m < arrays.Count; m++) {
            if(m != indexOfUsedArray) {
                int tempValue = Math.Abs(arrays[m][0]);
                if(smallestValue > tempValue) {
                    smallestValue = tempValue;
                    index = m;
                }
            }
        }

        return index;
    }
}