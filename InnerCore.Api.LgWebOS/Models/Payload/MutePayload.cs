using System.Runtime.Serialization;

namespace InnerCore.Api.LgWebOS.Models.Payload
{
	[DataContract]
	public class MutePayload
	{
		[DataMember(Name = "mute")]
		public bool Mute { get; set; }
	}
}