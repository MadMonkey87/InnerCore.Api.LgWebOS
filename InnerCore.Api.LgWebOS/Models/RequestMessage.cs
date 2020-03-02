namespace InnerCore.Api.LgWebOS.Models
{
	public class RequestMessage
	{
		public RequestMessage(string uri)
		{
			Uri = uri;
			Type = RequestType.Request;
		}

		public string Prefix { get; set; }

		public RequestType Type { get; set; }

		public string Uri { get; set; }

		public string Payload { get; set; }
	}
}
