using System;
using System.Collections.Generic;
using System.Text;

namespace InnerCore.Api.LgWebOS.Models
{
    internal class RawRequestMessage
    {
        public RawRequestMessage()
        {

        }

        public RawRequestMessage(RequestMessage requestMessage, int commandCount)
        {
            var prefix = (requestMessage.Prefix ?? "");
            Id = prefix + (prefix.Length > 0 ? "_" : "") + commandCount;
            Type = requestMessage.Type;
            Uri = requestMessage.Uri;
            Payload = requestMessage.Payload;
        }


        public string Id { get; set; }

        public RequestType Type { get; set; }

        public string Uri { get; set; }

        public string Payload { get; set; }
    }
}
