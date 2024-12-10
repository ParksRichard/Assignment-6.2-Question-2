/*
Given an integer array nums, return an array answer such that
answer[i] is equal to the product of all the elements of nums
except nums[i]
Must run in linear time?
*/

//define variables
//make array
//do math.length i<, i++
//looks like would almost be a hash or matrix
//isolate index element then multiply all other elements
//loop through array to create products into second array

namespace Assignment_6._2_Question_2
{
    internal class Program
    {
        public int[] ExceptionArray(int[] nums)
        {
            //exclusion array?
            int n = nums.Length; //numnumnums
            int[] result = new int[n];

           //double loop for maths - no division
            result[0] = 1; //set index=+1 for right/left mathing
            for (int i = 1; i < n; i++)
            {
                result[i] = result[i - 1] * nums[i - 1]; 
            }
            //produce product of array nums - one element ot the left or right
            //count form both sides like a previous array assignment thing. 
            int suffix = 1; 
            for (int i = n - 1; i >= 0; i--)
            {
                result[i] *= suffix;  //multipication for products
                suffix *= nums[i]; //no division for whatever it was
            }
            return result;
        }
        //i.e - prefix and suffix array, or left and right hand
        
        static void Main()
        {
            var solution = new Program();

            Console.WriteLine("Welcome to the Hardcoded Array exclusion multiplier!");
            Console.WriteLine("");

            //Hardcode example numero uno
            int[] nums1 = { 1, 2, 3, 4 };
            int[] result1 = solution.ExceptionArray(nums1);
            Console.WriteLine("Example 1: Initial Array: ");
            //loop through numbers to print
            foreach (int num in nums1)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Example 1: Product of Array: ");
            foreach (int res in result1)
            {
                Console.Write(res + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("");

            //hardcode example numero dos
            int[] nums2 = { -1, 1, 0, -3, 3 };
            int[] result2 = solution.ExceptionArray(nums2);
            Console.WriteLine("Example 2: Initial Array: ");
            foreach (int num in nums2)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Example 2: Product of Array: ");
            foreach (int res in result2)
            {
                Console.Write(res + " ");
            }
            Console.WriteLine("");
        }
    }
}
