using System;

class Iland
{
    public static int noOfIlands(char[,] grid)
    {
        int count =0;

        for (int i = 0; i <= grid.Rank; i++)
        {
            for (int j = 0; j <= grid.Rank; j++)
            {
                if (grid[i, j] == '1')
                {
                    count++;
                    callBFS(grid, i, j);
                }

            }
        }
        return count;
    }

    public static void callBFS(char[,] grid, int i, int j)
    {

        if (i < 0 || i >= grid.Rank  || j < 0 || j >= grid.Rank || grid[i, j] == '0')
            return;
        grid[i, j] = '0';
        callBFS(grid, i + 1, j);
        callBFS(grid, i - 1, j);
        callBFS(grid, i, j + 1);
        callBFS(grid, i, j - 1);


    }

    public static void MainC(string[] args)
    {
        char[,] A = new char[,] { { '1', '1', '0' }, { '1', '0', '1' }, { '0', '0', '0' } };
        int count = noOfIlands(A);
        Console.WriteLine("No of Ilands are  " + count);

    }
}
