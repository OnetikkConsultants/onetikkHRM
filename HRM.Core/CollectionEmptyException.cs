using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace HRM.Core
{
    [Serializable]
    public class CollectionEmptyException : Exception
    {
        public CollectionEmptyException()
        {
        }

        public CollectionEmptyException(string message)
            : base(message)
        {
        }

        public CollectionEmptyException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected CollectionEmptyException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
