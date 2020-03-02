using System.Runtime.Serialization;

namespace InnerCore.Api.LgWebOS.Models
{
	public enum RequestType
	{
		[EnumMember(Value = "register")]
		Register = 1,

		[EnumMember(Value = "request")]
		Request = 2,

		[EnumMember(Value = "subscribe")]
		Subscribe = 3,

		[EnumMember(Value = "unsubscribe")]
		Unsubscribe = 4,

		[EnumMember(Value = "response")]
		Response = 5,
	}
}
