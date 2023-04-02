using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test Case 1
            int[] nums1 = { 2, 7, 11, 15 };
            int targets1 = 9;
            int[] result1 = TwoSumEqualTarget(nums1, targets1);
            Console.WriteLine($"the indeces of the firts num is: {result1[0]} and the second is: {result1[1]}");

            //Test Case 2
            int[] nums2 = { 3, 2, 4 };
            int targets2 = 6;
            int[] result2 = TwoSumEqualTarget(nums2, targets2);
            Console.WriteLine($"the indeces of the firts num is: {result2[0]} and the second is: {result2[1]}");

            //Test Case 3
            int[] nums3 = { 3, 3 };
            int targets3 = 6;
            int[] result3 = TwoSumEqualTarget(nums3, targets3);
            Console.WriteLine($"the indeces of the firts num is: {result3[0]} and the second is: {result3[1]}");

            //Test Case 4
            int[] nums4 = { 1, 1, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 };
            int targets4 = 6;
            int[] result4 = TwoSumEqualTarget(nums4, targets4);
            Console.WriteLine($"the indeces of the firts num is: {result4[0]} and the second is: {result4[1]}");

        }
        public static int[] TwoSumEqualTarget(int[] nums, int target)
        {
            int[] resultIndeces = new int[2];
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int rem = target - nums[i];
                if (dict.ContainsKey(rem))
                {
                    resultIndeces[0] = dict[rem];
                    resultIndeces[1] = i;
                    break;

                }
                else if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], Array.IndexOf(nums, nums[i]));
                    //Console.WriteLine(" index : " + Array.IndexOf(nums, nums[i]));
                }

            }
            return resultIndeces;
        }
    }
    
}
