using System;
class Program
{
    static void Main() {
        int[] nums = { 1, 2, 2, 3, 4, 4, 4 };
        appears(nums);

    }
    static void appears(int[] nums) {
        int count = 0;
        for (int i = 0; i < nums.Length; i++) {
            for (int j = 0; j < nums.Length; j++) { 
                if(nums[i] == nums[j]) count++;
                Console.WriteLine(nums[i] +" appears " + count);
            }
        }
    }
}