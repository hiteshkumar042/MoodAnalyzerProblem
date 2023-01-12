using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblem;
using System;

namespace MoodAnalyzer_TestProject
{

    [TestClass]
    public class MoodAnalyzerTest
    {
        [TestMethod]
        [TestCategory("Exception Test Cases")]
        [DataRow("I am in Happy Mood", "HAPPY")]
        [DataRow("I am in Sad Mood", "SAD")]
        [DataRow(null, "Object reference not set to an instance of an object.")]
        public void MessageShouldReturn_TypeOfMood(string message, string expected)
        {
            try
            {
                //Arrange
                MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
                //Act
                string actual = moodAnalyzer.AnalyzeMood();
                //Assert
                if (actual != null)
                {
                    Assert.AreEqual(expected, actual);
                    Console.WriteLine("Result : " + actual);
                }
            }
            catch (Exception ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}
