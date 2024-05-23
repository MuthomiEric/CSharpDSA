namespace C_Sharp_Dsa
{
    internal class ThreeDimensionalArray
    {
        public static void Implementation()
        {
            int[,,] numbers = new int[3, 2, 3];

            int[,,] array3D = {
            {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12}
            }
        };

            int rows = array3D.GetLength(0);

            int columns = array3D.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                //for (int j = 0; j < columns; j++)
                //{
                //    Console.Write(array2D[i, j] + " ");
                //}
                //Console.WriteLine();
            }
        }
    }
}
