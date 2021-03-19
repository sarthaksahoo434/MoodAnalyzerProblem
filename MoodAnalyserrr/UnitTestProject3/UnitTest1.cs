using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserrr;
namespace UnitTestProject3
{
    [TestClass]
    public class UnitTest1
    {

    [TestMethod]
        public void Given_When_NullMood_Then_Throw_MoodAnalysisException()
        {
            try
            {
                string message = null;
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                string mood = moodAnalyser.AnalyaseMood();
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood should not be null", e.Message);
            }
        }

       
        [TestMethod]
        public void Given_When_EmptyMood_Then_Throw_MoodAnalysisException_indicating_EmptyMood()
        {
            try
            {
                string message = "";
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                string mood = moodAnalyser.AnalyaseMood();
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood should not be Empty", e.Message);
            }
        }
    }
}
