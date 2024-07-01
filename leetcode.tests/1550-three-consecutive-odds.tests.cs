namespace leetcode.tests.s1550;

using leetcode.s1550;

public class SolutionTests()
{
    [Fact]
    public void Test1()
    {
        // Given
        var soln = new Solution();
        int[] arr = [2,6,4,1];
        // When
        var actualResponse = soln.ThreeConsecutiveOdds(arr);

        var expectedResponse = false;
        // Then
        Assert.Equal(expectedResponse, actualResponse);
    }

    [Fact]
    public void Test2()
    {
        // Given
        var soln = new Solution();
        int[] arr = [1,2,34,3,4,5,7,23,12];
        // When
        var actualResponse = soln.ThreeConsecutiveOdds(arr);

        var expectedResponse = true;
        // Then
        Assert.Equal(expectedResponse, actualResponse);
    }
}