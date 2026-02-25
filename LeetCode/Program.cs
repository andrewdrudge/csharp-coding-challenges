public class Program {
    public static void Main(string[] args)
    {
        int[] nums = [2, 7, 11, 15];
        int target = 9;
        TwoSum twoSum = new TwoSum();
        int[] result = twoSum.twoSum(nums, target);
        int[] answer = [0, 1];
        Console.WriteLine(string.Join(",", result));
        Console.WriteLine(string.Join(",", answer)); // sample
        Console.WriteLine("TwoSum passed?: " + result.SequenceEqual(answer));
    }
}