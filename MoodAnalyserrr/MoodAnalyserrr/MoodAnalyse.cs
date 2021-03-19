﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserrr
{
    public class MoodAnalyser
    {
        private readonly string message;

        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public MoodAnalyser()
        {
        }
        public string AnalyaseMood()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be Empty");

                }
                if (this.message.Contains("Sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NULL_MESSAGE, "Mood should not be Null");
            }
        }

    }
}
