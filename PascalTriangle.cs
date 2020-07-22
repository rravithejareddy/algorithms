using System;
using System.Collections.Generic;

namespace Pascalalgos
{

    class Program
    {
        public static List<List<int>> Pascal(int numRows)
        {
            List<List<int>> traingle = new List<List<int>>();

            if (numRows == 1)
                return traingle;



            List<int> firstRow = new List<int>();
            firstRow.Add(1);

            traingle.Add(firstRow);

            for (int i = 1; i < numRows; i++)
            {
                List<int> row = new List<int>();

                List<int> prev_row = traingle[i - 1];
                row.Add(1);
                for (int j = 1; j < i; j++)
                {
                    row.Add(prev_row[j - 1] + prev_row[j]);
                }

                row.Add(1);

                traingle.Add(row);

            }
            return traingle;
        }

        public static void MainC(string[] args)
        {

            Pascal(5);

        }

    }
}

