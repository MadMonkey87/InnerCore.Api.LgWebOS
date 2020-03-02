using System.Runtime.Serialization;

namespace InnerCore.Api.LgWebOS.Models
{
    [DataContract]
    internal class RawRequestMessage
    {
        public RawRequestMessage()
        {

        }

        public RawRequestMessage(RequestMessage requestMessage, int commandCount)
        {
            Id = commandCount.ToString();
            Type = requestMessage.Type;
            Uri = requestMessage.Uri;
            Payload = requestMessage.Payload;
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
