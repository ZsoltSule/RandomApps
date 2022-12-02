using System;
namespace binaryClock
{
    class Program
    {
        static void Main(string[] args)
        {
            String data = DateTime.Now.ToString("HH:MM:SS");
            String[] line = data.Split(':');
            Console.WriteLine($"H:{base10Conversion(2, line[0][0])}");
            Console.WriteLine($"H:{base10Conversion(2, line[0][1])}");
            Console.WriteLine($"M:{base10Conversion(2, line[1][0])}");
            Console.WriteLine($"M:{base10Conversion(2, line[1][1])}");
            Console.WriteLine($"S:{base10Conversion(2, line[2][0])}");
            Console.WriteLine($"S:{base10Conversion(2, line[2][1])}");
        }
        /// <summary>
        /// Converts a number from base 10 
        /// </summary>
        /// <param name="b1"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        private static string base10Conversion(int b1, int num)
        {
            string result = "";
            Stack<char> mystack = new Stack<char>();
            while (num > 0)
            {
                mystack.Push((char)('0' + num % b1));
                num /= b1;
            }
            foreach (char e in mystack)
                result += e;
            return result;
        }
    }
}