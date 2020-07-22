using System;
using System.Collections.Generic;
using System.Linq;

namespace DuplicatedInArr
{
    class DupArr
    {
        public static bool Duplicates(int[] nums)
        {
            HashSet<int> numbs = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {

                if (numbs.Contains(nums[i])) return true;

                numbs.Add(nums[i]);

            }
            return false;
        }
        public static int CalculateAverage(IEnumerable<int> numbers)
        {
            // Write your code here
            List<int> nums = numbers.ToList();
            List<int> checkRepeat = new List<int>();
            double total = 0;
            int avg = 0;

            for (int i = 0; i < nums.Count; i++)
            {
                if (!checkRepeat.Contains(nums[i]))
                    checkRepeat.Add(nums[i]);

            }

            foreach (int n in checkRepeat)
            {
                total += n;
            }

            avg = (int)Math.Ceiling(total / checkRepeat.Count);

            return avg;

        }
        public static String check_special(int n, int p)
        {
            int count = 0;
            while (n % 2 == 0)
            {

                n /= 2;
                count++;
            }


            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {

                while (n % i == 0)
                {

                    n /= i;
                }
            }


            if (n  >= 2)
            {
                return "YES";
            }

            return "NO";
        }

        public static void MainC(string[] args)
        {
            int[] nums = new int[] { 1, 2, 2, 3 };
            // Duplicates(nums); 

            // CalculateAverage(nums);

            check_special(2, 7);
        }

    }

}
