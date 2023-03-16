using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodCheck
    {
        public string AnalizeMood(string message)
        {
            if (message.Contains("Sad"))
                return "Sad";
            else
                return "Happy";

        }
    }
}
