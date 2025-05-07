using System;
class Program
{
    static void Main()
    {
        int[] nums = { 1, 2, 2, 3, 4, 4, 4 };
        appears(nums);

    }
    static void appears(int[] nums)
    {
        bool[] visited = new bool[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            if (visited[i]) continue;
            int count = 1;
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j])
                {
                    count++;
                    visited[j] = true;
                }
            }

            Console.WriteLine(nums[i] + " appears " + count);
        }
    }
}