using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CharCounter charCounter = new CharCounter();

            Console.WriteLine(string.Format("Test Case 1: {0}", charCounter.SplitAndCount("aaabccccdd")));
            Console.WriteLine(string.Format("Test Case 2: {0}", charCounter.SplitAndCount("yyyyyzzzzzzzzzz")));
            Console.WriteLine(string.Format("Test Case 3: {0}", charCounter.SplitAndCount("abcd")));
            Console.WriteLine(string.Format("Test Case 4: {0}", charCounter.SplitAndCount("hhhccchhhccc")));
            Console.ReadLine();
        }
    }
}
