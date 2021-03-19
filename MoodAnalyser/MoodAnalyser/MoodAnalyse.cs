using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
   public class MoodAnalyse
    {
        private string Message;
        public MoodAnalyse(string Message)
        {
            this.Message = Message;
        }
        public string AnalyseMood()
        {
            if (this.Message.Contains("Sad"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
    }
}
