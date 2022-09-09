
namespace selfStudy.types
{
    internal class ObjectTypes
    {
        public int MyProperty { get; }
        public ObjectTypes()
        {
            // most likely to be the reference type
            Console.WriteLine(" \n--- This is ObjectTypes constructor ---");
            string s = "1t's A string!?";
            MyProperty = s.Length;
    }
    }
}
