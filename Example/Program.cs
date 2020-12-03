using System;
using System.Threading.Tasks;

namespace Example
{
    internal class Program
    {
        /// <summary>
        ///   What will be the output?
        /// </summary>
        string str1 = "Hello";
        public static void Main()
        {
            str1 += " World";
            Console.WriteLine(str1);
        }
    }
    //******************************************************************
    //******************************************************************
    internal class Programtry
    {
        /// <summary>
        ///   What will be the output?
        /// </summary>
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
    //******************************************************************
    //******************************************************************
    internal class ProgramString
    {
        /// <summary>
        ///   What will be the output?
        /// </summary>
        public void Main()
        {
            string str1 = "name1";
            string str2 = "name1";
            if (ReferenceEquals(str1, str2))
            {
                Console.WriteLine("Hello World!");
            }
            Console.ReadLine();
        }
    }
    //******************************************************************
    //******************************************************************
    internal class ProgramRefactor
    {
        /// <summary>
        /// Is there a way to modify ClassA so that you can you call the constructor with parameters,
        /// when the Main method is called, without creating any other new instances of the ClassA?
        /// </summary>
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
    //******************************************************************
    //******************************************************************
    internal class ProgramInc
    {
        /// <summary>
        /// What will be output and why?
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int i = 0;
            Console.Write(i++ + Calculate(i));
            Console.WriteLine(i);
            Console.ReadKey();
        }
        public static int Calculate(int i)
        {
            Console.Write(i++);
            return i;
        }
    }
    //******************************************************************
    //******************************************************************
    internal class Programvirtual
    {
        /// <summary>
        /// What will be output and why?
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            A c1 = new C();
            C c2 = new C();
            c1.Print();
            c2.Print();
            Console.ReadLine();
        }
        class A
        {
            public virtual void Print()
            {
                Console.WriteLine("A");
            }
        }
        class B : A
        {
            public override void Print()
            {
                Console.WriteLine("B");
            }
        }
        class C : B
        {
            public new void Print()
            {
                Console.WriteLine("C");
            }
        }
    }
    //******************************************************************
    //******************************************************************
    internal class ProgramThread
    {
        /// <summary>
        /// What is the output of the program below? Explain your answer.    
        /// Also, would the answer change if we were to replace 
        /// await Task.Delay(5)  with 
        /// Thread.Sleep(5) ? Why or why not?
        /// </summary>
        private static string result;
        static void Main()
        {
            Task<string> str = SaySomething();
            Console.WriteLine(result);
        }
        static async Task<string> SaySomething()
        {
            await Task.Delay(5); //Thread.Sleep(5)
            result = "Hello world!";
            return "Something";
        }
    }
}