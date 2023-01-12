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
            MoodAnalyzer mood1 = new MoodAnalyzer("I'm in Sad Mood");
            Console.WriteLine("I'm in Sad Mood : " + mood1.AnalyzeMood());
            MoodAnalyzer mood2 = new MoodAnalyzer("I'm in Happy Mood");
            Console.WriteLine("I'm in Any Mood : " + mood2.AnalyzeMood());

            //UC2:-Null mood 
            MoodAnalyzer mood3 = new MoodAnalyzer(" ");
            Console.WriteLine("Null Message : " + mood3.AnalyzeMood());

            Console.ReadLine();//Hold the Screen
        }
    }
    
}
