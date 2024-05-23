namespace C_Sharp_Dsa
{
    internal class ThreeDimensionalArray
    {
        public static void Implementation()
        {
            int[,,] threeDArray = new int[3, 3, 3];

            for (int i = 0; i < threeDArray.GetLength(0); i++)
            {
                for (int j = 0; j < threeDArray.GetLength(1); j++)
                {
                    for (int k = 0; k < threeDArray.GetLength(2); k++)
                    {
                        if (i == 2 && j == 2 && k == 2)
                        {
                            Console.WriteLine(threeDArray[i, j, k]);

                            break;
                        }
                    }
                }
            }
        }
    }
}
