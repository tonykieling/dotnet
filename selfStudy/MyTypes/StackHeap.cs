
namespace selfStudy.types
{
    internal class StackHeap
    {
        /* stack is managed by the SO
         * value types may be stored here, depends on the way they area created
         * also the references for the reference type variables reside on the stack
         * --- when a value type is declared in the top level of class, 
         *      this variable will be allocated in the heap, not in the stack
         * --- another way when value types are stored in the heap is by boxing (when a primitive is converted to an object)
         */

        /* heap is managed by the compiler, and applies garbage collector to it
         * reference types are allocated within this area.
         * value types may recorded in here (and ths stack, as well)
         */

        public StackHeap()
        {
            Console.WriteLine(" \n--- This is StackHeap constructor ---");

        }
    }
}
