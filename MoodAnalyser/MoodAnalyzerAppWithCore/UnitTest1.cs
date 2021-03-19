using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;
namespace MoodAnalyzerAppWithCore
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string expected = "SAD";
            string Message = "I am in sad Mood";
            MoodAnalyse moodAnalyse = new MoodAnalyse(Message);

            string mood = moodAnalyse.AnalyseMood();

            Assert.AreEqual(expected, mood);
        }
    }
}
