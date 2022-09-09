
namespace selfStudy.types
{
    internal class MyTypes
    {
        public MyTypes()
        {
            Console.WriteLine($"\n##### MyTypes constructor #####");
            var _ = new PrimitiveTypes();
            var _2 = new ObjectTypes();
            var _3 = new StackHeap();
        }
    }
}
