namespace C_Sharp_Dsa
{
    internal static class TwoDImensionalArray
    {
        public static void Implementation()
        {
            int[,] arr = new int[5, 3];

            arr[0, 0] = 9;

            int[,] array2D = new int[,]
            {
                { 9, 5, -9 },
                { -11, 4, 0 },
                { 6, 115, 3 },
                { -12, -9, 71 },
                { 1, -6, -1 }
            };

            int rows = array2D.GetLength(0);

            int columns = array2D.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(array2D[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
