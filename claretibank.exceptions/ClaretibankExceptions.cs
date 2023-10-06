using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaretiBank.claretibank.Exceptions
{

	[Serializable]
	public class ClaretiBankException : Exception
	{
		public ClaretiBankException() { }
		public ClaretiBankException(string message) : base("oops... algo deu errado, causa do erro --->" + message) { }
		public ClaretiBankException(string message, Exception inner) : base(message, inner) { }
		protected ClaretiBankException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
