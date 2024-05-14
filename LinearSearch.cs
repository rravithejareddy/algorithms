using System;



    class LinearSearch
    {

        public static void MainC(string[] args)
        {

            int[] arr = { 2, 3, 4, 10, 40 };
            int f = 10;

            LinearSearch linearSearch = new LinearSearch();

            int res = linearSearch.linearSearch(arr, f);

            Console.Write("result\t"+res);
        }

        public int linearSearch(int[] arr, int f)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == f)
                {
                    return i+1;
                }              
            }
             return -1;
        }
    }
