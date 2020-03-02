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

		public const string URL_PLAY = "ssap://media.controls/play";

		public const string URL_PAUSE = "ssap://media.controls/pause";

		public const string URL_STOP = "ssap://media.controls/stop";

		public const string URL_REWIND = "ssap://media.controls/rewind";

		public const string URL_FAST_FORWARD = "ssap://media.controls/fastForward";

		public const string URL_CLOSE = "ssap://media.viewer/close";

		public const string URL_TURN_OFF = "ssap://system/turnOff";

		public const string URL_SHOW_TOAST = "ssap://system.notifications/createToast";

		public const string URL_LAUNCH = "ssap://system.launcher/launch";
	}
}
