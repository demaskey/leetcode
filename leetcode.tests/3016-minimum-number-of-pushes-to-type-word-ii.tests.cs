namespace leetcode.tests.s3016;

using leetcode.s3016;

public class SolutionTests()
{
    [Fact]
    public void Test1()
    {
        var soln = new Solution();

        string word = "abcde";

        int actualMinimumPushes = soln.MinimumPushes(word);

        int expectedMinimumPushes = 5;

        Assert.Equal(expectedMinimumPushes, actualMinimumPushes);
    }

    [Fact]
    public void Test2()
    {
        var soln = new Solution();

        string word = "xyzxyzxyzxyz";

        int actualMinimumPushes = soln.MinimumPushes(word);

        int expectedMinimumPushes = 12;

        Assert.Equal(expectedMinimumPushes, actualMinimumPushes);
    }

    [Fact]
    public void Test3()
    {
        var soln = new Solution();

        string word = "aabbccddeeffgghhiiiiii";

        int actualMinimumPushes = soln.MinimumPushes(word);

        int expectedMinimumPushes = 24;

        Assert.Equal(expectedMinimumPushes, actualMinimumPushes);
    }

    [Fact]
    public void Test4()
    {
        var soln = new Solution();

        string word = "hiknogatpyjzcdbe";

        int actualMinimumPushes = soln.MinimumPushes(word);

        int expectedMinimumPushes = 24;

        Assert.Equal(expectedMinimumPushes, actualMinimumPushes);
    }
}