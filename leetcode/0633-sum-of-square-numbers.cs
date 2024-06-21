namespace leetcode.s0633;

public class Solution {
    public bool JudgeSquareSum(int c) {
        var sqrRoot = Math.Sqrt((double)c);

        var a = Math.Floor(sqrRoot);

        double b = 0;
        var cMinusA = c - a * a;

        if(cMinusA != 0)  {
            var sqrRootB = Math.Sqrt(cMinusA);

            b = Math.Floor(sqrRootB);
        }

        double sum = 0;

        do {
            sum = a * a + b * b;
            if(sum == c ) return true;
            else if(sum > c) a--;
            else b++;
        } while (a > 0);
        return false;
    }
}