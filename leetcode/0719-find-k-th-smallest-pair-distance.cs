using System.Collections.Immutable;

namespace leetcode.s0719;

public class Solution {
    public int SmallestDistancePair(int[] nums, int k) {
        Array.Sort(nums);
        int low = 0;
        int high = nums[nums.Length - 1] - nums[0];

        while (low < high) {
            int mid = low + (high - low) / 2;
            if (CountPairs(nums, mid) >= k) {
                high = mid;
            } else {
                low = mid + 1;
            }
        }

        return low;
    }

    private int CountPairs(int[] nums, int mid) {
        int count = 0;
        int j = 0;

        for (int i = 0; i < nums.Length; i++) {
            while (j < nums.Length && nums[j] - nums[i] <= mid) {
                j++;
            }
            count += j - i - 1;
        }

        return count;
    }

    public int FirstTry_SmallestDistancePair(int[] nums, int k) {
        List<int> listSmallestDistancePairs = new List<int>();

        for (int i = 0; i < nums.Length -1; i++) {
            for (int j = i + 1; j < nums.Length; j++) {
                int distanceBetweenPair = Math.Abs(nums[i] - nums[j]);
                if(listSmallestDistancePairs.Count < k) {
                    listSmallestDistancePairs.Add(distanceBetweenPair);
                } else if(distanceBetweenPair < listSmallestDistancePairs.Max()) {
                    int indexOfMax = listSmallestDistancePairs.IndexOf(listSmallestDistancePairs.Max());
                    listSmallestDistancePairs[indexOfMax] = distanceBetweenPair;
                }
            }
        }

        listSmallestDistancePairs.Sort();

        return listSmallestDistancePairs[k - 1];
    }
    public int SecondTry_SmallestDistancePair(int[] nums, int k) {
        List<int> listNums = new List<int>(nums);
        var listOfDistinct = listNums.Distinct();

        Dictionary<int, int> countOfDistance = new Dictionary<int, int>();

        int countOfZeroDistance = 0;

        // calculate the number pairs with a distance of zero
        foreach(int distinctValue in listOfDistinct) {
            int countOfValue = listNums.FindAll(x => x == distinctValue).Count;

            if(countOfValue > 1) {
                countOfZeroDistance += CalculateCombinations(countOfValue, 2);

            }
        }

        countOfDistance.Add(0, countOfZeroDistance);

        for(int i = 0; i < listOfDistinct.Count() - 1; i++) {
            for (int j = i+1; j < listOfDistinct.Count(); j++) {
                int distanceBetween = Math.Abs(listOfDistinct.ElementAt(i) - listOfDistinct.ElementAt(j));
                if(!countOfDistance.ContainsKey(distanceBetween)) {
                    countOfDistance.Add(distanceBetween, 0);
                }

                int countAtDistance = listNums.FindAll(x => x == listOfDistinct.ElementAt(i)).Count * listNums.FindAll(x => x == listOfDistinct.ElementAt(j)).Count;

                countOfDistance[distanceBetween] += countAtDistance;
            }
        }

        int countToK = 0;

        var sortedKeyValuePair = countOfDistance.ToImmutableSortedDictionary();

        foreach(KeyValuePair<int,int> value in sortedKeyValuePair) {
            int key = value.Key;
            countToK += value.Value;

            if(countToK >= k) {
                return key;
            }
        }

        return -1;
    }

    private int CalculateCombinations(int objects, int sample){
        int factorialObjects = CalculateFactorial(objects);
        int factorialSample = CalculateFactorial(sample);
        int factorialObjectsMinusSample = CalculateFactorial(objects - sample);

        return factorialObjects / (factorialSample * factorialObjectsMinusSample);
    }

    private int CalculateFactorial(int value) {
        int calculation = 1;
        for(int i = 2; i <= value; i++) {
            calculation *= i;
        }

        return calculation;
    }
}