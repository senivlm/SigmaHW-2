namespace HW_2_Sidletskyi
{
    public class MatrixBigestLine : Matrix
    {
        int[,] matrix = { { 15, 2, 10, 15, 15},
                          { 3, 3, 3, 15, 3},
                          { 5, 4, 4, 4, 3} };

        public MatrixBigestLine(int a, int b) : base(a, b)
        {
            array = matrix;
        }

        public void ColorOfTheBigestHorizontalLine()
        {
            int count = 1, longestCount = 1, longestNum = 0;
            int startIndex = 0, lastIndex = 0, row = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] != matrix[i,j - 1])
                    {
                        count = 0;
                    }
                    count++;

                    if (count >= longestCount)
                    {
                        longestCount = count;
                        longestNum = matrix[i,j];
                        startIndex = j - longestCount + 1;
                        lastIndex = j;
                        row = i;
                    }
                }
                count = 0;
            }
            Console.WriteLine($"Color of the longest horizontal line: {longestNum}");
            Console.WriteLine($"Row: {row}");
            Console.WriteLine($"Start index: {startIndex}");
            Console.WriteLine($"Last index: {lastIndex}");
            Console.WriteLine($"Line length: {longestCount}");
        }
    }
}
