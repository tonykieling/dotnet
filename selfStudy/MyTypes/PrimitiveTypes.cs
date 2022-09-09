
namespace selfStudy.types
{
    internal class PrimitiveTypes
    {
        public PrimitiveTypes()
        {
            // it looks like the primitive types are value types
            /* bool, char, 
             * byte, sbyte, short, ushort, int, uint, nint, nuint, long, ulong, 
             * float, double, decimal
             * struct, enum, tuples
             */
            Console.WriteLine(" \n--- PrimitiveTypes constructor ---");
            //Number - Integer
            sbyte sb = -1;
            byte by = 11;
            // byte ushort uint ulong for unsigned
            short sh = -2;
            ushort ush = 22;
            int i = 3;
            long l = 4;
            Console.WriteLine($"sbyte size: {sizeof(byte)}, short size: {sizeof(short)}, int: {sizeof(int)}, " +
                $"long size: {sizeof(long)}");
            // Number - floating point
            float fl = 5.0f;
            double dou = 6.0d;
            decimal m = 7.0m;
            Console.WriteLine($"float size: {sizeof(float)}, double size: {sizeof(double)}, decimal: {sizeof(decimal)}");
            // Other types
            char c = 'c';
            bool tf = true;
            string st = "this 1s a sTring!";
            Console.WriteLine($"char size: {sizeof(char)}, bool size: {sizeof(bool)}, string: 'it is an object, that means a reference type'");

            //var test = "it's test";
            //var test = 10;
            var test = new ObjectTypes();
            Console.WriteLine($"test variable is: '{test}' and its type is: {test.GetType()}");
        }
    }
}
