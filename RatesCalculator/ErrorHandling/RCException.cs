namespace RatesCalculator.ErrorHandling
{
    using System;

    public class RCException : Exception
    {
        public ErrorCode ErrorCode { get; private set; }

        public RCException(ErrorCode errorCode, string message) : base(message)
        {
            ErrorCode = errorCode;
        }
    }
}
