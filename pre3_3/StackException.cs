using System.Runtime.Serialization;

namespace inheritance_and_polymorphisum_3
{
    [Serializable]
    internal class StackException : Exception
    {
        public StackException()
        {
        }

        public StackException(string? message) : base(message)
        {
        }

        public StackException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected StackException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}