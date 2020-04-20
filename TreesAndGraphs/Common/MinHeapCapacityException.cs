using System;
using System.Runtime.Serialization;

namespace org.pv.Common
{
	[Serializable]
	internal class EmptyHeapException : Exception
	{
		public EmptyHeapException()
		{
		}

		public EmptyHeapException(string message) : base(message)
		{
		}

		public EmptyHeapException(string message, Exception innerException) : base(message, innerException)
		{
		}

		protected EmptyHeapException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}