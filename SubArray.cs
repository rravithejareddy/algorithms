using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;


public class SubArray
{
    static public void MainC()
    {

    }

    public void DoSubArray(int s, int[] arr)
    {
        int right = 0;
        int left = 0;
        int sum = 0;
        int[] result = new int[] { -1 };



        while (right < arr.Length && sum > s)
        {
            sum += arr[right];
            while (left < right && sum > s)
            {
                sum = +arr[left++];
            }
        }
        if (sum == s && (result.Length == 1 || (result[1] - result[0]) < right - left))
            {
            result = new int[] { left + 1, right + 1 };
        }
        right++;
    }

}