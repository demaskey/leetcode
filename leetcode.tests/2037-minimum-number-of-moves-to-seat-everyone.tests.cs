namespace leetcode.tests.s2037;

using leetcode.s2037;

public class SolutionTest
{
    [Fact]
    public void Test1()
    {
        var soln = new Solution();

        int[] seats = [3, 1, 5];
        int[] students = [2, 7, 4];

        int answer = soln.MinMovesToSeat(seats, students);

        Assert.Equal(4,answer);
    }

    [Fact]
    public void Test2()
    {
        var soln = new Solution();

        int[] seats = [4,1,5,9];
        int[] students = [1,3,2,6];

        int answer = soln.MinMovesToSeat(seats, students);

        Assert.Equal(7,answer);
    }

    [Fact]
    public void Test3()
    {
        var soln = new Solution();

        int[] seats = [2,2,6,6];
        int[] students = [1,3,2,6];

        int answer = soln.MinMovesToSeat(seats, students);

        Assert.Equal(4,answer);
    }
}