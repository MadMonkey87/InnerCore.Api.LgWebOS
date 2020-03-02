using System.Collections.Generic;
using System.Runtime.Serialization;

namespace InnerCore.Api.LgWebOS.Models.Payload
{
	[DataContract]
	public class LaunchPointsPayload
	{
		[DataMember(Name = "launchPoints")]
		public List<LaunchPoint> LaunchPoints { get; set; }
	}
}
