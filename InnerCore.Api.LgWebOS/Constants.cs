namespace InnerCore.Api.LgWebOS
{
	public struct Constants
	{
		public const int WEB_SOCKET_RECEIVE_BUFFER_SIZE = 2048;

		public const int WEB_SOCKET_SEND_BUFFER_SIZE = 2048;

		public const string URL_GET_SERVICE_LIST = "ssap://api/getServiceList";

		public const string URL_MUTE = "ssap://audio/setMute";

		public const string URL_GET_STATUS = "ssap://audio/getStatus";

		public const string URL_GET_VOLUME = "ssap://audio/getVolume";

		public const string URL_SET_VOLUME = "ssap://audio/setVolume";

		public const string URL_VOLUME_UP= "ssap://audio/volumeUp";

		public const string URL_VOLUME_DOWN = "ssap://audio/volumeDown";
	}
}
