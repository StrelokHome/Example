using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Example
{
    /// <summary>
    /// What is the output of the program below? Explain your answer.    
    /// Also, would the answer change if we were to replace 
    /// await Task.Delay(5)  with 
    /// Thread.Sleep(5) ? Why or why not?
    /// </summary>
    class Program
    {
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
