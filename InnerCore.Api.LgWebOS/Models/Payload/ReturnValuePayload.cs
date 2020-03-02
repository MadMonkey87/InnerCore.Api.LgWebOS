using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace InnerCore.Api.LgWebOS.Models.Payload
{
	[DataContract]
	public class ReturnValuePayload
	{
		[DataMember(Name = "returnValue")]
		public bool ReturnValue { get; set; }
	}
}
