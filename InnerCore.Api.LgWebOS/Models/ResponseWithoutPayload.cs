using System.Runtime.Serialization;

namespace InnerCore.Api.LgWebOS.Models
{
	[DataContract]
	public class ResponseWithoutPayload
	{
		[DataMember(Name = "id")]
		public string Id { get; set; }

		[DataMember(Name = "type")]
		public RequestType Type { get; set; }
	}
}
