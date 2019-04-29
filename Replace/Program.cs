using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replace
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "please contact the \nadministrator";
            Console.WriteLine(input);
            string output = input.Replace('\n', ' ');
            Console.WriteLine(output);
            Console.Read();
        }
    }
}
