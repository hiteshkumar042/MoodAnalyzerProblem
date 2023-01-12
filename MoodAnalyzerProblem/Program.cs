using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyzer..!");
            //UC1:-Respond Happy and Sad Mood
            MoodAnalyzer mood = new MoodAnalyzer();
            string mood1 = mood.AnalyzeMood("I'm in Sad Mood");
            Console.WriteLine("I'm in Sad Mood : " + mood1);
            string mood2 = mood.AnalyzeMood("I'a in Any Mood");
            Console.WriteLine("I'm in Any Mood : " + mood2);

            Console.ReadLine();
        }
    }
}
