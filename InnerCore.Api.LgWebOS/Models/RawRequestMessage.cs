using System.Runtime.Serialization;

namespace InnerCore.Api.LgWebOS.Models
{
    [DataContract]
    internal class RawRequestMessage
    {
        public RawRequestMessage(int commandCount, string uri, object payload = null)
        {
            Id = commandCount.ToString();
            Type = RequestType.Request;
            Uri = uri;
            Payload = payload;
        }

        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "type")]
        public RequestType Type { get; set; }

        [DataMember(Name = "uri")]
        public string Uri { get; set; }

        [DataMember(Name = "payload")]
        public object Payload { get; set; }
    }
}
