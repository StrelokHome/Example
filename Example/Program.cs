using System;

namespace Example
{
    /// <summary>
    /// Is there a way to modify ClassA so that you can you call the constructor with parameters,
    /// when the Main method is called, without creating any other new instances of the ClassA?
    /// </summary>
    internal class Program
    {
        class ClassA
        {
            public ClassA()
            { }
            public ClassA(int pValue)
            {
                Console.WriteLine("Congratulations !! You have refactored the code.");
            }
        }
        static void Main(string[] args)
        {
            ClassA refA = new ClassA();
        }
    }
}
