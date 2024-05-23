using DocumentFormat.OpenXml.Wordprocessing;
using System.Linq.Expressions;

namespace C_Sharp_Dsa
{
    internal class JaggedArray
    {
        public static void Implementation()
        {
            int[][] numbers = new int[4][];
            numbers[0] = new int[] { 9, 5, 6, 7 };
            numbers[1] = new int[] { 0, -3, 12 };
            numbers[3] = new int[] { 54 };

            //This code can be simplified with a collection expression, as follows: in C# 12
            int[][] numbers2 = new int[4][];
            numbers2[0] = [9, 5];
            numbers2[1] = [0, -3, 12];
            numbers2[3] = [54];

        }
    }
}
