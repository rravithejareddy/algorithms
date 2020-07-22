
class Flipping
{

    public static int[, ] FlippingImage(int[, ] A)
    {

        for (int i = 0; i <= A.Rank; i++)
        {

            int low = 0;
            int high = A.Rank;

            while (low <= high)
            {
                if (A[i,low] == A[i,high])
                {
                    A[i,low] = 1 - A[i,low];
                    A[i,high] = A[i,low];
                }

                low++;
                high--;

            }

        }

        return A;
    }
    public static void MainC(string[] args)
    {
        int[, ] A = new int[, ]{{1,1,0},{1,0,1},{0,0,0}};
        FlippingImage(A);

    }
}