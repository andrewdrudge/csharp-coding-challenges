public class TwoSum // rename to Solution if copying code to LeetCode
{
    public int[] twoSum(int[] nums, int target) // capitalize first letter of method name if copying code to LeetCode
    {
        int[] indices = [];
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    indices = [i, j];
                }
            }
        }
        return indices;
    }
}