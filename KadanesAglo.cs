using System;

class Kadanes
{
    public static void MainC(string[] args)
    {

        int[] arr = { -2, 2, 5, -11, 6, 12, 35, -35,40, 65,55,-100, -300};

        Kadanes kadanes = new Kadanes();
        int res = kadanes.kadanes(arr);

        Console.Write("result \t" + res);
    }

    public int kadanes(int[] arr)
    {
        int maxSum = arr[0];
        int currSum = maxSum;
        for (int i = 1; i < arr.Length; i++)
        {

            currSum = Math.Max(currSum + arr[i], arr[i]);

            maxSum = Math.Max(currSum, maxSum);
        }

        return maxSum;
    }
}

