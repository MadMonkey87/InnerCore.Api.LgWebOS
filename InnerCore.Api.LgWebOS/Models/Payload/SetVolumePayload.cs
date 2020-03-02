using System.Runtime.Serialization;

namespace InnerCore.Api.LgWebOS.Models.Payload
{
	[DataContract]
	public class SetVolumePayload
	{
		[DataMember(Name = "volume")]
		public int Volume { get; set; }
	}
}
