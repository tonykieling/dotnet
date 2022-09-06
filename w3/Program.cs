using System;
using w3;

//ArrayClass ma = new ArrayClass();

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
    } catch (Exception e)
    {
        Console.WriteLine($"Error: {e}");
    }
    Console.WriteLine("\n");
}

// Singledirectional Array
/* int[] arr = new int[5];
   arr[0] = 1; */
/* int[] arr = new int[] { 1, 2, 3 }; */
int[] arr = {1, 2, 3 };
print1DArray(arr);

// Multidrecional Array
int[,] arr2 = new int[3, 3] { { 1, 2, 3 }, {4, 5, 6 }, {7, 8, 9 } };
print2DArray(arr2);

// Jagged Array
Object[][] arr3 = new Object[4][];
//arr3[0] = new int[] { 11, 22, 33 };
//arr3[1] = new int[] { 11, 22, 33, 44};
arr3[3] = new string[] { "11", "22", "33", "333333333" };
//arr3[2] = new int[] { 11, 22 };
//arr3[3] = new int[] { 11, 22, 33, 44, 55 };
printJaggedArray(arr3);

int x = 3;
int[] tempK = new int[x];
print1DArray(tempK);
