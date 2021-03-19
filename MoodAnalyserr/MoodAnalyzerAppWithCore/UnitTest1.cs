using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MoodAnalyzerAppWithCore
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow ("I am in HAPPY Mood")]
        [DataRow(null)]
        public void GivenHAPPYMoodShouldreturnHAPPY(string Message)
        {
            string expected = "HAPPY";
            MoodAnalyse moodAnalyse = new MoodAnalyse(Message);

            string mood = moodAnalyse.AnalyseMood();

            Assert.AreEqual(expected, mood);
        }
    }
}
