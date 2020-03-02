using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace InnerCore.Api.LgWebOS.Models.Payload
{
	[DataContract]
	public class FordergroundAppInfoPayload : ReturnValuePayload
	{
		[DataMember(Name = "appId")]
		public string AppId { get; set; }

		[DataMember(Name = "processId")]
		public string ProcessId { get; set; }

		[DataMember(Name = "windowId")]
		public string WindowId { get; set; }
	}
}
