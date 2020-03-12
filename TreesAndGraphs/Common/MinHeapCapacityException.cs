using System;
using System.Runtime.Serialization;

namespace org.pv.Common
{
	[Serializable]
	internal class EmptyMinHeapException : Exception
	{
		public EmptyMinHeapException()
		{
		}

		public EmptyMinHeapException(string message) : base(message)
		{
		}

		public EmptyMinHeapException(string message, Exception innerException) : base(message, innerException)
		{
		}

		protected EmptyMinHeapException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}