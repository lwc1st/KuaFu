﻿namespace Velen.Application.Exceptions
{
    public class InvalidCommandException : Exception
    {
        public string Details { get; }
        public InvalidCommandException(string message, string details) : base(message)
        {
            this.Details = details;
        }
    }
}