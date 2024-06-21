namespace leetcode.s1052;

public class Solution {
    public int MaxSatisfied(int[] customers, int[] grumpy, int minutes) {
        int maxSatisfied = 0;

        // brute force
        for(int i = 0; i < customers.Length - minutes + 1; i++) {
            var tempGrumpy = (int[])grumpy.Clone();
            for(int m = 0; m < minutes; m++) {
                tempGrumpy[i + m] = 0;
            }
            
            var tempSatisfied = CalculateSatisfiedCustomers(customers, tempGrumpy);

            if(tempSatisfied > maxSatisfied) {
                maxSatisfied = tempSatisfied;
            }
        }

        return maxSatisfied;
    }

    private int CalculateSatisfiedCustomers(int[] customers, int[] grumpy) {
        int satisfiedCustomers = 0;
        for(int i = 0; i < customers.Length; i++) {
            if(grumpy[i] == 0) {
                satisfiedCustomers += customers[i];
            }
        }

        return satisfiedCustomers;
    }
}