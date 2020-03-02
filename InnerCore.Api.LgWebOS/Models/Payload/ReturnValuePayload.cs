using System.Runtime.Serialization;

namespace InnerCore.Api.LgWebOS.Models.Payload
{
	[DataContract]
	public class ReturnValuePayload
	{
		[DataMember(Name = "returnValue")]
		public bool ReturnValue { get; set; }
	}
}
