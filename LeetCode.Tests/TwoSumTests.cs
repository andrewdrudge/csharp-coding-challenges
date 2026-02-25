using Xunit;

public class TwoSumTests
{
    [Fact]
    public void TwoSum_Example1()
    {
        var s = new TwoSum();
        int[] nums = new[] { 2, 7, 11, 15 };
        int target = 9;
        var result = s.twoSum(nums, target);
        Assert.Equal(new[] { 0, 1 }, result);
    }

    [Fact]
    public void TwoSum_Example2()
    {
        var s = new TwoSum();
        int[] nums = new[] { 3, 2, 4 };
        int target = 6;
        var result = s.twoSum(nums, target);
        Assert.Equal(new[] { 1, 2 }, result);
    }

    [Fact]
    public void TwoSum()
    {
        var s = new TwoSum();
        int[] nums = new[] { 3, 3 };
        int target = 6;
        var result = s.twoSum(nums, target);
        Assert.Equal(new[] { 0, 1 }, result);
    }

    [Fact]
    public void TwoSum_Returns_Empty_When_No_Solution()
    {
        var s = new TwoSum();
        int[] nums = new[] { 1, 2, 3 };
        int target = 7;
        var result = s.twoSum(nums, target);
        Assert.Empty(result);
    }
}
