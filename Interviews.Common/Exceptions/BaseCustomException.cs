using System;

namespace Interviews.Common.Exceptions
{
    public class BaseCustomException : Exception
    {
        public BaseCustomException(string message, string description, int code) : base(message)
        {
            Code = code;
            Description = description;
        }

        public int Code { get; }
        public string Description { get; }
    }
}
