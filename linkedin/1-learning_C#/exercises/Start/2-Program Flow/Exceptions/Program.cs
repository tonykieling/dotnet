using System;

namespace Exceptions
{
		class Program
		{
				static void Main(string[] args)
				{
						int x = 100;
						int y = 0;
						int result;

						// TODO: try-catch expressions make error checking easier
						try {
								if (x > 1000)
										// throw new ArgumentOutOfRangeException("x", "this is an error message.");
										throw new Exception(" This is the message for a Generic Error");

								result = x / y;
								Console.WriteLine("The result is: {0}", result);

						} catch (DivideByZeroException e) {
								Console.WriteLine($" Error: {e.Message}");

						} catch (ArgumentOutOfRangeException e) {
								Console.WriteLine($" ops: {e.Message}");
								
						} catch (Exception e) {
								Console.WriteLine($" XXX - Generic Error: {e.Message}");

						} finally {
								Console.WriteLine("this is the last line!!!!!!");
						}
				}
		}
}
