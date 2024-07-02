using System.ComponentModel;
using System.Data;

namespace leetcode.s0350;

public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        List<int> smallerNums, largerNums;

        if(nums1.Length >= nums2.Length) {
            smallerNums = new List<int>(nums2);
            largerNums = new List<int>(nums1);
        } else {
            smallerNums = new List<int>(nums1);
            largerNums = new List<int>(nums2);
        }

        List<int> intersection = new List<int>();

        foreach(int num in smallerNums) {
            if(largerNums.Exists( x => x == num)) {
                intersection.Add(num);
                largerNums.Remove(num);
            }
        }
        
        return [.. intersection];
    }
}