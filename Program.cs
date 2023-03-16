using MoodAnalyzer;

namespace MoodAnalyser
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MoodAnalyserClass mood = new MoodAnalyserClass();
            mood.AnalizeMood("I am Sad");
            Console.ReadLine();
        }
    }
}
