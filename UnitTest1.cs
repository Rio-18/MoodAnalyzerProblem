
namespace MoodAnalyzerTC

{
    public class Class
    {


        [Test]
        public void GivenSadMood_WhenAnalized_ShouldReturnSad()
        {
            MoodCheck mood = new MoodCheck("I am in Sad Mood");
            string result = mood.AnalizeMood();
            Assert.AreEqual("Sad", result);
        }
        [Test]
        public void GivenHappyMood_WhenAnalized_ShouldReturnHappy()
        {
            MoodCheck mood = new MoodCheck("I am in Happy Mood");
            string result = mood.AnalizeMood();
            Assert.AreEqual("Happy", result);
        }
        [Test]
        public void GivenNullMood_WhenAnalized_ShouldReturnHappy()
        {
            MoodCheck mood = new MoodCheck(null);
            string result = mood.AnalizeMood();
            Assert.AreEqual("Happy", result);
        }

    }


}
