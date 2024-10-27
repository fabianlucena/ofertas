﻿namespace RFService.Exceptions
{
    public class NullFieldException : Exception
    {
        public NullFieldException(string name)
            : base($"Field {name} cannot be null.")
        { }
    }
}
