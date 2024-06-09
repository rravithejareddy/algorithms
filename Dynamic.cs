using System;

namespace DynamicAlgo
{
    class Dynamics
    {
        static int MAX = 100;
        static int NIL = -1;
        static int[] lookup = new int[MAX];

        /* Function to initialize NIL  
        values in lookup table */
        static void initialize()
        {
            for (int i = 0; i < MAX; i++)
                lookup[i] = NIL;
        }

        public static int Memorizarion(int n)
        {


            if (lookup[n] == NIL) b
            {
                if (n <= 1)
                    lookup[n] = n;
                else
                {
                    lookup[n] = Memorizarion(n - 1) + Memorizarion(n - 2);
                }
            }

            return lookup[n];
        }
       static int fib(int n) 
    { 
        int []f = new int[n + 1]; 
        f[0] = 0; 
        f[1] = 1; 
        for (int i = 2; i <= n; i++) 
            f[i] = f[i - 1] + f[i - 2]; 
        return f[n]; 
    } 
       
          
        
    public static void MainC(string[] args)
    {
        initialize();
        Console.Write(Memorizarion(9));


    }
}
}

