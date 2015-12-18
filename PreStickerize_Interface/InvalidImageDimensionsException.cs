using System;
using System.Runtime.Serialization;

namespace PreStickerize_Interface
{
    [Serializable]
    internal class InvalidImageDimensionsException : Exception
    {
        public InvalidImageDimensionsException()
        {
        }

        public InvalidImageDimensionsException(string message) : base(message)
        {
        }

        public InvalidImageDimensionsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidImageDimensionsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}