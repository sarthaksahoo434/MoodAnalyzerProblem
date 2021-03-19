﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserrr
{
    public class MoodAnalyserCustomException : Exception
    {

        public enum ExceptionType
        {
            NULL_MESSAGE,
            EMPTY_MESSAGE,
            NO_SUCH_FIELD,
            NO_SUCH_METHOD,
            NO_SUCH_CLASS,
            OBJECT_CREATION_ISSUE
        }
        private ExceptionType type;
        public MoodAnalyserCustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }

    }

}

