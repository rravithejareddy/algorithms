using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;


public class HelloWorld
{
    static public void MainC()
    {
        string prime_factor = Console.ReadLine();
        int P = Convert.ToInt32(prime_factor);

        string line = Console.ReadLine();
        int T = Convert.ToInt32(line);

        for (int t_i = 0; t_i < T; t_i++)
        {
            line = Console.ReadLine();
            int n = Convert.ToInt32(line);

            String out_ = check_special(n, P);
            Console.WriteLine(out_);
        }
    }

    static String check_special(int n, int p)
    {
        // This function returns YES if the given number is special number , NO
        // otherwise

        double N =n;
       int count =0;

        while (N % 2 == 0)
        {

            N /= 2;

        }
        int sqrRoot = (int)Math.Ceiling(Math.Sqrt(N));
        for (int i = 3; i <= sqrRoot; i += 2)
        {

            while (N % i == 0)
            {

                N /= i;
            }
          ///   if (N > 2) 
            
            
        }

        if (N > 2)
        {

            return "YES";
        }

        return "NO";
    }

}