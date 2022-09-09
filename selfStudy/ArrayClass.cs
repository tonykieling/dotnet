
namespace selfStudy
{
    public class ArrayClass
    {
        static string Name { get => "This is Array part"; }

        string[] colors = { "green", "red", "blue" };
        int[] numbers = { 8, 18, 36 };
        public ArrayClass()
        {
            Console.WriteLine($"### {Name}");
            Console.WriteLine($" - colors: {ListItems(colors)}");
            Console.WriteLine($"First color is: {colors[0]}");
            Console.WriteLine($" - numbers: {ListItems(numbers)}");
            Console.WriteLine($"Second number is: {numbers[1]} and the last color is {numbers[numbers.Length -1]}");

            // Add new number
            Console.WriteLine(AddItem(8));

            // Add new color
            Console.WriteLine(AddItem("white"));
        }
        //private string ListColors()
        //{
        //    string s = "";
        //    foreach (string color in colors)
        //        s += $"- {color} -";

        //    return s;
        //}
        static string ListItems(Array items)
        {
            string s = "";
            if ((items.GetType().Name).ToLower().Contains("string"))
                foreach (string item in items)
                   s += $"- {item} -";
            else
                foreach (int item in items)
                    s += $"- {item.ToString()} -";


            return s;
        }

        //public string AddItem(Object newItem)
        //{
        //    var newList = colors.ToList();
        //    Console.WriteLine($"=> newItem: {newItem}, {newItem.GetType().Name}");
        //    Console.WriteLine($"  - BEFORE: {ListItems(colors)}");;
        //    if (newItem.GetType().Name.ToLower().Contains("string"))
        //    {
        //        //colors = colors.Append(newItem.ToString()).ToArray();

        //        //var newList = colors.ToList();
        //        //newList.Add("newstuff");
        //        //colors = newList.ToArray();

        //        newList.Add(newItem.ToString());
        //        colors = newList.ToArray();
        //    } else
        //    {
        //        string temp = newItem.ToString();
        //        newList.Add(temp.ToInt32());
        //    }
        //    Console.WriteLine($"  - AFTER: {ListItems(colors)}");
        //    return "";
        //}
        public string AddItem(string newItem)
        {
            var newList = colors.ToList();
            Console.WriteLine("Adding new COLOR");
            Console.WriteLine($"  - BEFORE: {ListItems(colors)}"); ;

            newList.Add(newItem);
            colors = newList.ToArray();
            
            return ($"  - AFTER: {ListItems(colors)}");
        }
        public string AddItem(int newItem)
        {
            var newList = numbers.ToList();
            Console.WriteLine($"newList: {newList}");
            Console.WriteLine("Adding new NUMBER");
            Console.WriteLine($"  - BEFORE: {ListItems(numbers)}"); ;

            newList.Add(newItem);
            numbers = newList.ToArray();

            return ($"  - AFTER: {ListItems(numbers)}");
        }
    }
}