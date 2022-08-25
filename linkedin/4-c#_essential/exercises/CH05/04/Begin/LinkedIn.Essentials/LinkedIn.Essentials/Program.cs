// See https://aka.ms/new-console-template for more information
//using LinkedIn.Essentials;

//string input = null;
//int? definiteInt = null;
string value;
while (1 == 1)
{
    Console.Write("number is: ");
    value = Console.ReadLine();
    Console.WriteLine("1: value is {0}", value);
    int res;
    bool p = int.TryParse(value, out res);
    if (!p)
    {
        Console.WriteLine("yeap");
        res = null;
    }
    if (value == null)
        Console.WriteLine("it's null");
    else if (value == "q")
        break;
    Console.WriteLine($"p: {p} - value: {value} - res: {res}");
    //else Console.WriteLine($"2: value is {value}");
}
