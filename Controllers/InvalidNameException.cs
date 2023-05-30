using System;


namespace Controllers
{
    public class InvalidNameException : Exception
    {
        public string InvalidName { get; set; }
        public InvalidNameException() : base() { }
        public InvalidNameException(string message) : base(message) { }
        public InvalidNameException(string massage, Exception innerException) : base(massage, innerException) { }
        public InvalidNameException(string massage, string invalidName) : base(massage)
        {
            InvalidName = invalidName;
        }
    }
}
