using Newtonsoft.Json;

namespace InnerCore.Api.LgWebOS.Models
{
	public class RequestMessage
	{
		//public RequestMessage(string uri, string payload, string prefix)
		//{
		//	Uri = uri;
		//	Payload = payload;
		//	Prefix = prefix;
		//}

		public RequestMessage(string uri, string prefix)
		{
			Uri = uri;
			Prefix = prefix;
			Type = RequestType.Request;
		}

		//public RequestMessage(string uri, object payload, string prefix)
		//{
		//	Uri = uri;
		//	Payload = JsonConvert.SerializeObject(payload);
		//	Prefix = prefix;
		//}

		public string Prefix { get; set; }

		public RequestType Type { get; set; }

		public string Uri { get; set; }

		//public string Payload { get; set; }
	}
}
