namespace C_Sharp_Dsa
{
    internal class SIngleDimensionalArray
    {
        static void Print()
        {
            int[] arr = new int[5];

            // Different way of initializing array values
            int[] numbers1 = new int[] { 9, -11, 6, -12, 1 };
            int[] numbers2 = { 9, -11, 6, -12, 1 };           //  int[] numbers3 = [9, -11, 6, -12, 1]; C# 12            arr[0] = 9;
            arr[1] = -11;
            arr[2] = 6;
            arr[3] = -12;
            arr[4] = 1;
            int last = numbers1[^1]; // Getting last element using index operator

            int rank = numbers1.Rank; // Getting the number of dimensions in array

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
