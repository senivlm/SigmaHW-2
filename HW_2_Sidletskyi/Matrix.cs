namespace HW_2_Sidletskyi
{
    public class Matrix
    {
        protected int[,] array;

        public Matrix(int a, int b)
        {
            array = new int[a,b];
        }

        public void InitializeByVerticalSnake()
        {
            int counter = 1;
            for (int i = 0; i < array.GetLength(1); i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < array.GetLength(0); j++)
                        array[j, i] = counter++;
                }
                else
                {
                    for (int j = array.GetLength(0) - 1; j >= 0; j--)
                        array[j, i] = counter++;
                }
            }
        }

        public void InitializeByDiagonalSnake()
        {
            int counter = 1;
            for (int i = 1; i <= (array.GetLength(0) + array.GetLength(1) - 1); i++)
            {
                int start_col = Math.Max(0, i - array.GetLength(0));
                int count = Math.Min(i, Math.Min((array.GetLength(1) - start_col), array.GetLength(0)));

                if (i % 2 == 0)
                {
                    for (int j = 0; j < count; j++)
                        array[start_col + j, Math.Min(array.GetLength(0), i) - j - 1] = counter++;
                }
                else
                {
                    for (int j = 0; j < count; j++)
                        array[Math.Min(array.GetLength(0), i) - j - 1, start_col + j] = counter++;
                }
            }
        }

        public void InitializeBySpiralSnake()
        {
            int k = 0, l = 0, counter = 1;
            int m = array.GetLength(0);
            int n = array.GetLength(1);

            while (k < m && l < n)
            {
                if (l < n)
                {
                    for (int i = k; i <= m - 1; ++i)
                    {
                        array[i, l] = counter++;
                    }
                l++;
                }

                if (k < m)
                {
                    for (int i = l; i <= n - 1; ++i)
                    {
                        array[m - 1, i] = counter++;
                    }
                m--;
                }

                for (int i = m-1; i >= k; --i)
                {
                    array[i, n - 1] = counter++;
                }
                n--;

                for (int i = n-1; i >= l; --i)
                {
                    array[k, i] = counter++;
                }
                k++;
            }
        }

        public void Print()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
