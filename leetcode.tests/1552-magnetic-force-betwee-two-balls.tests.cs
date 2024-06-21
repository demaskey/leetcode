namespace leetcode.tests.s1552;

using System.ComponentModel.DataAnnotations;
using leetcode.s1552;

public class SolutionTests()
{
    [Fact]
    public void Test1()
    {
        // Given
        var soln = new Solution();
        int[] position = [1,2,3,4,7];
        int m = 3;
        // When
        var actualDistance = soln.MaxDistance(position,m);

        var expectedDistance = 3;
        // Then
        Assert.Equal(expectedDistance, actualDistance);
    }

    [Fact]
    public void Test2()
    {
        // Given
        var soln = new Solution();
        int[] position = [5,4,3,2,1,1000000000];
        int m = 2;
        // When
        var actualDistance = soln.MaxDistance(position,m);

        var expectedDistance = 999999999;
        // Then
        Assert.Equal(expectedDistance, actualDistance);
    }

    [Fact]
    public void Test3()
    {
        // Given
        var soln = new Solution();
        int[] position = [5,4,3,2,1,1000000000];
        int m = 3;
        // When
        var actualDistance = soln.MaxDistance(position,m);

        var expectedDistance = 4;
        // Then
        Assert.Equal(expectedDistance, actualDistance);
    }

    [Fact]
    public void Test4()
    {
        // Given
        var soln = new Solution();
        int[] position = [1,2,3,4,7];
        int m = 4;
        // When
        var actualDistance = soln.MaxDistance(position,m);

        var expectedDistance = 1;
        // Then
        Assert.Equal(expectedDistance, actualDistance);
    }

    [Fact]
    public void Test5()
    {
        // Given
        var soln = new Solution();
        int[] position = [79,74,57,22];
        int m = 4;
        // When
        var actualDistance = soln.MaxDistance(position,m);

        var expectedDistance = 5;
        // Then
        Assert.Equal(expectedDistance, actualDistance);
    }

    [Fact]
    public void Test6()
    {
        // Given
        var soln = new Solution();
        int[] position = [4784,9049,3151,7537,2734,1287,2875,6770,9565,6254,6898,2509,6583];
        int m = 13;
        // When
        var actualDistance = soln.MaxDistance(position,m);

        var expectedDistance = 128;
        // Then
        Assert.Equal(expectedDistance, actualDistance);
    }

    [Fact]
    public void Test7()
    {
        // Given
        var soln = new Solution();
        int[] position = [94,95,37,30,67,7,5,44,26,55,42,28,97,19,100,74,13,88,18];
        int m = 7;
        // When
        var actualDistance = soln.MaxDistance(position,m);

        var expectedDistance = 12;
        // Then
        Assert.Equal(expectedDistance, actualDistance);
    }
    
}