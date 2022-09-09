
namespace selfStudy
{
    public class MoreArrayStuff
    {
        void print1DArray(int[] a)
        {
            Console.WriteLine("--- 1D Array");
            string result = "[";
            for (int i = 0; i < a.Length; i++)
                result = result + a[i] + (i == (a.Length - 1) ? "]" : ", ");

            Console.WriteLine($"Array is: {result}\n");
        }

        void print2DArray(int[,] mArray)
        {
            //Console.WriteLine($"{mArray.Length.ToString()}, {mArray.Rank}, {mArray.GetLength(0)}, {mArray.GetLength(1)}");
            Console.WriteLine("--- 2D Array\nArrays is: ");
            for (int i = 0; i < mArray.GetLength(0); i++)
            {
                string temp = "[";
                for (int k = 0; k < mArray.GetLength(1); k++)
                    temp = temp + mArray[i, k] + (k == (mArray.GetLength(1) - 1)
                        ? (mArray.GetLength(1) == k - 1) ? "]\n" : "]"
                        : ", ");

                Console.WriteLine($"{temp}\n");
            }
        }

        void printJaggedArray(Object[][] arr)
        {
            Console.WriteLine("--- Jagged Array\nArrays is: ");
            try
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    if (arr[i] == null) continue;

                    Console.Write($" Array {i + 1} has {arr[i].Length} items: ");
                    string temp = "[";
                    for (int k = 0; k < arr[i].Length; k++)
                        temp = temp + arr[i][k] + (k == (arr[i].Length - 1)
                            ? (arr[i].Length == k - 1) ? "]\n" : "]"
                            : ", ");

                    Console.WriteLine($"{temp}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e}");
            }
            Console.WriteLine("\n");
        }
        
        void printObjArray(Object[] arr)
        {
            string formatType(string t)
            {
                if (t.Length == 0)
                    return "";
                if (int.TryParse(t, out int i))
                    return i.ToString();
                if (char.TryParse(t, out char c))
                    return $"'{c.ToString()}'";
                if (t.ToLower() == "true")
                    return "True";
                if (t.ToLower() == "false")
                    return "False";
                return $"\"{t}\"";
            }
            Console.Write($"--- Array of Objects\n[");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write((i == arr.Length - 1)
                    ? $"{formatType(arr[i].ToString())}]\n"
                    : $"{formatType(arr[i].ToString())}, ");
            }
        }


        public MoreArrayStuff()
        {
            Console.WriteLine("TESTTTTTTTTTTTTTTTTT");
            // Singledirectional Array
            int[] arr = new int[5];
            arr[0] = 1;
            /* int[] arr = new int[] { 1, 2, 3 }; */
            //int[] arr = { 1, 2, 3 };
            print1DArray(arr);

            // Multidrecional Array
            int[,] arr2 = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            print2DArray(arr2);

            // Jagged Array
            Object[][] arr3 = new Object[4][];
            //arr3[0] = new int[] { 11, 22, 33 };
            //arr3[1] = new int[] { 11, 22, 33, 44};
            arr3[3] = new string[] { "11", "22", "33", "333333333" };
            //arr3[2] = new int[] { 11, 22 };
            //arr3[3] = new int[] { 11, 22, 33, 44, 55 };
            printJaggedArray(arr3);

            int x = 4;
            object[] tempK = new object[x];
            tempK[0] = 'x';
            tempK[1] = -1;
            tempK[2] = "test text";
            tempK[3] = true;
            printObjArray(tempK);
        }
    }
}
