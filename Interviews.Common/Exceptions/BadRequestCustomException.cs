using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Interviews.Common.Exceptions
{
    public class BadRequestCustomException : BaseCustomException
    {
        public BadRequestCustomException(string message, string description) : base(message, description, (int)HttpStatusCode.BadRequest)
        {

        }
    }
}
