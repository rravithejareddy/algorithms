using System;

namespace KMP
{
    class KMPAlgo
    {

        public static void KMP(string patt, string txt)
        {
            int n = txt.Length;
            int m = patt.Length;

            int[] lps = new int[m];

            int j = 0;
            int i = 0;

            computeLPSArray(patt, m, lps);


            while (i < n)
            {
                if (patt[j] == txt[i])
                {
                    j++;
                    i++;
                }
                if (j == m)
                {
                    Console.Write("found pattern at index" + (i - j));
                    j = lps[j - 1];
                }

                else if (i < n && patt[j] != txt[i])
                {
                    if (j != 0)
                        j = lps[j - 1];
                    else
                        i = i + 1;


                }
            }
        }


        public static void computeLPSArray(string patt, int m, int[] lps)
        {
            int len = 0;
            int i = 1;

            while (i < m)
            {
                if (patt[len] == patt[i])
                {
                    len++;
                    lps[i] = len;
                   
                     i++;
                }
                else
                {
                    if (len != 0)
                    {
                        len = lps[len - 1];
                    }
                    else
                    {
                        lps[i] = len;
                        i++;
                    }
                }
            }



        }
        public static void MainC(string[] args)
        {
            string txt = "ABABDABACDABABCABAB";
            string pat = "ABABCABAB";
            KMP(pat, txt);

        }
    }
}

