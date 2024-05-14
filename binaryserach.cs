using System;

class BinarySerach
{
    public static int binarySearch(int [] arr, int l, int r, int f ){
        if(r >=1){
            int pos = l+(r-l)/2;
            if(f == arr[pos]){
                return pos;
            }
            if(arr[pos] > f){
               return binarySearch(arr,l, pos-1,f );
            }
            
               return binarySearch(arr,pos+1, r, f);
            
            
        }
        return -1;
    }

    public static void MainC(string[] args)
    {
        
        int[] arr = { 2, 3, 4, 10, 40 }; 
        int n = arr.Length; 
        int x = 10; 
  
        int result = binarySearch(arr, 0, n - 1, x); 
  
        if (result == -1) 
            Console.WriteLine("Element not present"); 
        else
            Console.WriteLine("Element found at index "
                              + result); 

    }
}

