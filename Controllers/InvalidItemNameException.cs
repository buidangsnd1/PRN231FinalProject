using System;

namespace Controllers
{
    public class InvalidItemNameException : Exception
    {
        public string InvalidItemName { get; set; }
        public InvalidItemNameException() : base() { }
        public InvalidItemNameException(string message) : base(message) { }
        public InvalidItemNameException(string massage, Exception innerException) : base(massage, innerException) { }
        public InvalidItemNameException(string massage, string invalidName) : base(massage) {
            InvalidItemName= invalidName;
        }
    }
}
