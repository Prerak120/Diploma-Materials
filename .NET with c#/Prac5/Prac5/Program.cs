namespace Prac5
{
    internal class Program
    {
        static void SwapByValue(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("Inside SwapByValue - a: " + a + ", b: " + b);
        }

        // Pass by Ref method
        static void SwapByRef(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("Inside SwapByRef - a: " + a + ", b: " + b);
        }

        // Pass by Out method
        static void SwapByOut(out int a, out int b)
        {
            a = 10;
            b = 20;
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("Inside SwapByOut - a: " + a + ", b: " + b);
        }

        static void Main()
        {
            // Pass by Value Example
            int x = 5, y = 10;
            Console.WriteLine("Before SwapByValue - x: " + x + ", y: " + y);
            SwapByValue(x, y);
            Console.WriteLine("After SwapByValue - x: " + x + ", y: " + y); // No change outside

            // Pass by Ref Example
            Console.WriteLine("\nBefore SwapByRef - x: " + x + ", y: " + y);
            SwapByRef(ref x, ref y);
            Console.WriteLine("After SwapByRef - x: " + x + ", y: " + y); // Changes outside

            // Pass by Out Example
            int a, b;
            Console.WriteLine("\nBefore SwapByOut - a: Not initialized, b: Not initialized");
            SwapByOut(out a, out b); // Out variables are initialized inside the method
            Console.WriteLine("After SwapByOut - a: " + a + ", b: " + b); // Changes after method call
        }
    }
}
