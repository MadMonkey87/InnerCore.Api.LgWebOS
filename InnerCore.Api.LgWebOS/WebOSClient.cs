using InnerCore.Api.LgWebOS.Models;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.WebSockets;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InnerCore.Api.LgWebOS
{
	public class WebOSClient : IDisposable
	{
		private readonly Uri _uri;

		private readonly ClientWebSocket _webSocket = new ClientWebSocket();

		private readonly ArraySegment<byte> buffer = WebSocket.CreateClientBuffer(Constants.WEB_SOCKET_RECEIVE_BUFFER_SIZE, Constants.WEB_SOCKET_SEND_BUFFER_SIZE);

		private int messageCount = 0;

		public WebOSClient(string ip, int port)
		{
			if (ip == null)
			{
				throw new ArgumentNullException(nameof(ip));
			}

			if (!Uri.TryCreate(string.Format("ws://{0}:{1}", ip, port), UriKind.Absolute, out _uri))
			{
				throw new Exception(string.Format("The supplied ip to the WebOS TV is not a valid ip: {0}:{1}", ip, port));
			}
		}

		public void Dispose()
		{
			_webSocket.Dispose();
		}

		private async Task<T> SendAsync<T>(RequestMessage request, CancellationToken cancellationToken) where T : SimplifiedResponse
		{
			await EnsureIsConnectedAsync(cancellationToken);
			// todo: ensure authorized

			var rawRequest = new RawRequestMessage(request, messageCount);
			var serializedRequest = JsonConvert.SerializeObject(rawRequest);

			await _webSocket.SendAsync(new ArraySegment<byte>(Encoding.UTF8.GetBytes(serializedRequest)), WebSocketMessageType.Text, true, cancellationToken);

			while (_webSocket.State == WebSocketState.Open && !cancellationToken.IsCancellationRequested)
			{
				var response = await _webSocket.ReceiveAsync(buffer, cancellationToken);

				if (response.MessageType == WebSocketMessageType.Close)
				{
					await _webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, string.Empty, cancellationToken);
					return null;
				}
				else if (response.MessageType != WebSocketMessageType.Text)
				{
					throw new NotSupportedException($"unsupported message type: {response.MessageType}");
				}
				else if (!response.EndOfMessage)
				{
					throw new NotSupportedException($"the message appears to be sent in chunks which is not supported");
				}
				else
				{
					var serializedResponse = Encoding.UTF8.GetString(buffer.Array).TrimEnd((char)0);
					var deserializedResponse = JsonConvert.DeserializeObject<T>(serializedResponse);
					if (deserializedResponse.Id == rawRequest.Id)
					{
						return deserializedResponse;
					}
				}
			}
			return null;
		}

		private async Task EnsureIsConnectedAsync(CancellationToken cancellationToken)
		{
			if (_webSocket.State != WebSocketState.Closed)
			{
				return;
			}
			messageCount = 0;
			await _webSocket.ConnectAsync(_uri, cancellationToken);
		}

		private string GetContentFromResource(string fileName = "InnerCore.Api.LgWebOS.RegistrationPayload.json")
		{
			string content;
			var assembly = typeof(Client).GetTypeInfo().Assembly;

			using (var stream = assembly.GetManifestResourceStream(fileName))
			{
				using (var reader = new StreamReader(stream))
				{
					content = reader.ReadToEnd();
				}
			}

			return content;
		}
	}
}
