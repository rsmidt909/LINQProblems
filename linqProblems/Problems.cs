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
        public List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };

        public void GetNames(List<string> names)
        {
            List<string> newnames = names.Distinct().ToList();
            foreach (string person in newnames)
            {
                Console.WriteLine(person);
            }
        }

        List<string> classGrades = new List<string>() { "80,100,92,89,65", "93,81,78,84,69", "73,88,83,99,64", "98,100,66,74,55" };
        List<double> AverageGrades = new List<double>();
        public void getAverage()
        {
            int i = 0;
            foreach (var person in classGrades)
            {

                var numbers = classGrades[i].Split(',').Select(Int32.Parse).ToList();
                var Minnumber = numbers.Min();
                numbers.Remove(Minnumber);
                double averageGrade = numbers.Average();
                AverageGrades.Add(averageGrade);
                i++;
            }
            double StudentsAverage = AverageGrades.Average();
            Console.WriteLine(StudentsAverage);

        }
    }
}
