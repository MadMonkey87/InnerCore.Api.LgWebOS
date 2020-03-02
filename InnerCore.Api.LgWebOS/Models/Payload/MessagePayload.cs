using System.Runtime.Serialization;

namespace InnerCore.Api.LgWebOS.Models.Payload
{
	[DataContract]
	public class MessagePayload
	{
		[DataMember(Name = "message")]
		public string Message { get; set; }
	}
}
