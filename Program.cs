namespace Assignment_5_1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 3, 1 };
            int[] nums2 = { 1, 2, 3, 4 };
            int[] nums3 = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };

            Console.WriteLine(ContainsDuplicate(nums1)); // Output: true
            Console.WriteLine(ContainsDuplicate(nums2)); // Output: false
            Console.WriteLine(ContainsDuplicate(nums3)); // Output: true
        }

        public static bool ContainsDuplicate(int[] nums)
        {
            // Create a Dictionary to store occurrences
            Dictionary<int, int> numCounts = new Dictionary<int, int>();

            // Iterate through the array
            foreach (int num in nums)
            {
                // If the number already exists in the dictionary, it's a duplicate
                if (numCounts.ContainsKey(num))
                {
                    return true;
                }
                else
                {
                    // Add the number to the dictionary with a count of 1
                    numCounts[num] = 1;
                }
            }

            // If no duplicates are found, return false
            return false;
        }
    }
}