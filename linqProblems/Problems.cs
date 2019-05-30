using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqProblems
{
    class Problems
    {


        public List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };

        public void checkLetter(List<string> words)
        {
            var keyLetters = words.Where(w => w.Contains("th"));

            foreach (string value in keyLetters)
            {
                Console.WriteLine(value);
            }

        }



        public void GetLetterFreq(string keyString)
        {

            var keyLetters = keyString.GroupBy(k => k).Select(x => x);

            foreach (var value in keyLetters)
            {

                Console.WriteLine(value.Key + value.Count().ToString());
                
            }

            
        }


    }
}
