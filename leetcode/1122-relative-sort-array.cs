namespace leetcode.s1122;

public class Solution {
    public int[] RelativeSortArray(int[] arr1, int[] arr2) {
        var newArr1 = new List<int>();
        

        for(int arr2Index = 0; arr2Index < arr2.Length; arr2Index++)
        {
            for (int arr1Index = 0; arr1Index < arr1.Length; arr1Index++)
            {
                if(arr2[arr2Index] == arr1[arr1Index])
                {
                    newArr1.Add(arr1[arr1Index]);
                }
            }
        }

        var leftoverArr1 = new List<int>();

        for (int arr1Index = 0; arr1Index < arr1.Length; arr1Index++)
        {
            if(!newArr1.Exists(x => x == arr1[arr1Index]))
            {
            leftoverArr1.Add(arr1[arr1Index]);
            }
        }

        leftoverArr1.Sort();

        foreach(int leftOver in leftoverArr1)
        {
            newArr1.Add(leftOver);
        }

        return newArr1.ToArray();
    }
}