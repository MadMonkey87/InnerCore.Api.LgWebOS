using System.Runtime.Serialization;

namespace InnerCore.Api.LgWebOS.Models
{
	[DataContract]
	public class ResponseWithPayload<T> : ResponseWithoutPayload
	{
		[DataMember(Name = "payload")]
		public T Payload { get; set; }
	}
}
