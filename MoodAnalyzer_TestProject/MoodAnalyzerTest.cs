using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblem;
using System;

namespace MoodAnalyzer_TestProject
{
    [TestClass]
    public class MoodAnalyzerTest
    {
        [TestMethod]
        public void MessageShouldReturnSAD_Testcase1_1()
        {
            //Arrange
            string expected = "SAD";
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer("I'm in Sad Mood");
            //Act
            string actual = moodAnalyzer.AnalyzeMood();
            Console.WriteLine("Result : " + actual);
            //Asset
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MessageShouldReturnHappy_Testcase1_2()
        {
            //Arrange
            string expected = "HAPPY";
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer("I'm in Any Mood");
            //Act
            string actual = moodAnalyzer.AnalyzeMood();
            Console.WriteLine("Result : " + actual);
            //Asset
            Assert.AreEqual(expected, actual);
        }
    }
}
