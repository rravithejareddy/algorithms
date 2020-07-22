using System;

namespace algos
{
    class Programs
    {
        public static int divideArr(int[] array, int l, int r, int s)
        {

            if (r >= 1)
            {
                int middle = l + (r - 1) / 2;

                if (array[middle] == s)
                    return middle;

                if (array[middle] > s)

                    return divideArr(array, l, middle - 1, s);



                return divideArr(array, middle + 1, r, s);

            }
            return -1;
        }

        static int binarySearch(int[] arr, int l,
                            int r, int x)
        {
            if (r >= l)
            {
                int mid = l + (r - l) / 2;

                // If the element is present at the 
                // middle itself 
                if (arr[mid] == x)
                    return mid;

                // If element is smaller than mid, then 
                // it can only be present in left subarray 
                if (arr[mid] > x)
                    return binarySearch(arr, l, mid - 1, x);

                // Else the element can only be present 
                // in right subarray 
                return binarySearch(arr, mid + 1, r, x);
            }

            // We reach here when element is not present 
            // in array 
            return -1;
        }

        public static void insertionSort(int[] arr)
        {
            int i,j;
            int key;

            for (i = 1; i < arr.Length; i++)
            {
                key = arr[i];

                j = i - 1;

                while (j >= 0 & arr[j] > key){
                arr[j + 1] = arr[j];
                j = j - 1;
            }

            arr[j + 1] = key;


        }

    }
    static void printArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; ++i)
            Console.Write(arr[i] + " ");

        Console.Write("\n");
    }
    static void MainTest(string[] args)
    {
        int[] array = { 2, 4, 3, 10, 40 };
        int n = array.Length;

        insertionSort(array);
        printArray(array);


    }
}
}
