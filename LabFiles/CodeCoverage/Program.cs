using System;

namespace CodeCoverage
{
    class Program
    {
        static void Main(string[] args)
        {
            Math m = new Math();
            try
            {
                /*********normal execution********/
                int result = m.Divide(4, 2);
                Console.WriteLine(result);
                /*********normal execution********/

                /*********Divide by zero error********/
                result = m.Divide(4, 0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
