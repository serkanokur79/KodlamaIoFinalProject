using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success, string message):this(success)
        {
           Message = message;
        }
        //contructor overloading
        public Result(bool success)
        {
            Success = success;
        }

        // no set => set with constructor!
        public bool Success { get; }

        public string Message { get; }
    }
}
