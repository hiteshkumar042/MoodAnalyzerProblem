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
            string mesage = "I am in sad Mood";
            string expected = "SAD";
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer();
            //Act
            string actual = moodAnalyzer.AnalyzeMood(mesage);
            Console.WriteLine("Result : " + actual);
            //Asset
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MessageShouldReturnHappy_Testcase1_2()
        {
            //Arrange
            string mesage = "I am in any Mood";
            string expected = "HAPPY";
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer();
            //Act
            string actual = moodAnalyzer.AnalyzeMood(mesage);
            Console.WriteLine("Result : " + actual);
            //Asset
            Assert.AreEqual(expected, actual);
        }
    }
}
