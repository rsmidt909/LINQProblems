using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Problems problems = new Problems();
            //List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };

            problems.GetLetterFreq("terrill");
            Console.ReadLine();
        }
    }
}
