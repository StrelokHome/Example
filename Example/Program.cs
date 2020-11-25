using System;

namespace Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new NullReferenceException();
                Console.WriteLine("After Null reference.");
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("Print from catch");
            }
            Console.WriteLine("End....");
            Console.ReadLine();
        }
    }
}
