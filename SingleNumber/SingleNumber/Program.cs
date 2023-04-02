using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleNumber
{
    class Program
    {
        // the Question : https://leetcode.com/problems/single-number/submissions/926249805/
        static void Main(string[] args)
        { 
            //test1
            int[] nums1 = { 1, 1,4, 2, 2 };
            int single1  =singleNumber(nums1);
            Console.WriteLine(single1);

            //test2
            int[] nums2 = { 2,2,1 };
            int single2 = singleNumber(nums2);
            Console.WriteLine(single2);

            //tese3
            int[] nums3 = { 1};
            int single3 = singleNumber(nums3);
            Console.WriteLine(single3);
        }
        public static int singleNumber(int[] nums)
        {
            int single=nums[0];
            Array.Sort(nums);  //1,1,2,2,3,6,6
            for(int i = 0; i < nums.Length - 1 ; i+=2)
            {
                
                if(nums[i] != nums[i + 1])
                {
                    return nums[i];  
                }
            }
            return nums[nums.Length-1];

        }







    }
}
