using System.Runtime.Serialization;

namespace InnerCore.Api.LgWebOS.Models.Payload
{
	[DataContract]
	public class VolumeDetailsPayload : ReturnValuePayload
	{
		[DataMember(Name = "muted")]
		public bool Muted { get; set; }

		[DataMember(Name = "volume")]
		public int Volume { get; set; }

		[DataMember(Name = "volumeMax")]
		public int VolumeMax { get; set; }

		[DataMember(Name = "scenario")]
		public string Scenario { get; set; }
	}
}
