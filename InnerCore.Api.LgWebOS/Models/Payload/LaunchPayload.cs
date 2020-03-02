using System.Runtime.Serialization;

namespace InnerCore.Api.LgWebOS.Models.Payload
{
	[DataContract]
	public class LaunchPayload
	{
		[DataMember(Name = "id")]
		public string Id { get; set; }

		[DataMember(Name = "contentId")]
		public string ContentId { get; set; }
	}
}
