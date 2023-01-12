using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzer
    {
        public string message;
        public MoodAnalyzer(string message)
        {
            this.message = message;
        }
        public string AnalyzeMood()
        {
            //UC2- Handle Exception if User Provides InvalidMood - Like NULL
            try
            {
                //Contains():- This method is used to check whether the substring occurs within a given string or not.
                if (message.ToLower().Contains("sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
                return default; //TC 2.1 For Null Return should be Happy)
            }
        }
    }
}
