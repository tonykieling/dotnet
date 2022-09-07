
namespace w3
{
    internal class Generics
    {
        //https://www.youtube.com/watch?v=7VlykMssZzk
        public Generics()
        {
            Console.WriteLine("starting constructor...");
            Console.WriteLine("\n### Array os ints ###");
            int a = 1, b = 22, c = 333;
            int[] t = { a, b, c };
            Console.WriteLine(ArrayToString(t));

            Console.WriteLine("\n### with Generics ###");
            var k = 10;
            var ch = 'c';
            var s = "string";
            var tf = true;
            var m = 1.234m;
            Object[] temp = {k, ch, s, tf, m};
            Console.WriteLine($"temp is type '{temp.GetType().Name}'");
            Console.WriteLine(ArrayToString(temp));

            Console.WriteLine("\n### Creating and printing an array of Generics ###");
            var temp2 = CreateArrayOfGenerics(temp);
            Console.WriteLine($"temp2 is type '{temp2.GetType().Name}'");

            Console.WriteLine(ArrayToString(temp2));
        }


        string ArrayToString<T>(T[] arr)
        {
            if (arr == null)
                return ("<empty>");

            if (arr.Length == 2)
                return ($"[{arr[0]}, {arr[1]}]");

            string result = $"[{arr[0]}, ";
            int lastIndex = arr.Length - 1;
            for (int i = 1; i < lastIndex; i++)
                result += $"{arr[i]}, ";

            result += $"{arr[lastIndex]}]";
            return result;
        }

        private T[] CreateArrayOfGenerics<T>(T[] items)
        {
            List<T> arr = new List<T>();
            foreach(T item in items)
                arr.Add(item);

            //ArrayToString(arr);
            return arr.ToArray();
        }
    }
}
