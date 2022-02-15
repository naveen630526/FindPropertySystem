using System;

namespace FPS.Exceptions
{
    public class CustomException : Exception
    {
        public CustomException() : base()
        {

        }
        public CustomException(String errorMessage) : base(errorMessage)
        {

        }
    }
}
