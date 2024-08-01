namespace leetcode.s2678;

public class Solution {
    public int CountSeniors(string[] details) {
        int countSeniors = 0;

        foreach(string passengerDetails in details) {
            string ageString = passengerDetails.Substring(11,2);
            int age = int.Parse(ageString);

            if(age > 60) {
                countSeniors++;
            }
        }
        return countSeniors;
    }
}