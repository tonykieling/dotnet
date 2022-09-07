
namespace w3
{
    internal class ListClass
    {
        //https://www.youtube.com/watch?v=vQzREQUhGSA
        /*
         * List is a data structure that represents a list of objects that can be accessed by index.
         * It is similar to Arrays, but can dynamically increase/decrease in size, 
         * but it uses more memory.
         * using System.Collections.Generic; // it seems the new version of c# doesn\t require this line
        */
        public ListClass()
        {
            Console.WriteLine("### starting with <List>");
            
            //string[] food = { "barbecue", "rice", "bean" };
            //food[3] = "any junk food"; // it will cause an error bkz the array is fixed in its creation

            // to overcome the error on line 18: List
            List<string> food = new List<string>();
            food.Add("lentils");
            food.Add("fish");
            food.Add("pork");
            food.Add(11.ToString());
            food.Remove("11");
            food.Insert(1, "sushi");
            food.RemoveAt(1);
            food.Add("pork");
            printList(food);
            Console.WriteLine($"first item on food is: {food[0]}, and the last one is: {food[food.Count - 1]}");
            Console.WriteLine($"'pork' is index: {food.IndexOf("pork")}");
            Console.WriteLine($"last 'pork' index is: {food.LastIndexOf("pork")}");
            Console.WriteLine($"food contais 'fish': {food.Contains("fish")}");
            food.Sort();
            Console.Write("food after sorting alphabetically is ==> ");
            printList(food);
            food.Reverse();
            Console.Write("food after reverse sorting alphabetically is ==> ");
            printList(food);

            string[] foodArray = food.ToArray();
            foreach(string foodItem in foodArray)
                Console.WriteLine(foodItem);

            food.Clear();
            Console.Write("food after cleaning is ==> ");
            printList(food);
        }

        void printList(List<string> list)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("<list is empty>");
                return;
            }
            string temp = "";
            for (int i = 0; i < list.Count; i++)
                temp += (
                    (i == 0)
                        ? $"[{list[i]}, "
                        : (i == list.Count - 1)
                            ? $"{list[i]}]"
                            : $"{list[i]}, ");
            Console.WriteLine(temp);
        }
    }
}
