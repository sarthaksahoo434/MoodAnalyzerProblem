using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserr
{
    class MoodAnalyse
    {
        private string Message;
        public MoodAnalyse(string Message)
        {
            this.Message = Message;
        }
        public string AnalyseMood()
        {
            try
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
            catch
            {
                return "HAPPY";
            }
            }
        }
    }

