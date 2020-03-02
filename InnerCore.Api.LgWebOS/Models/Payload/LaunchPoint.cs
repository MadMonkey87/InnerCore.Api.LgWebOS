using System.Collections.Generic;
using System.Runtime.Serialization;

namespace InnerCore.Api.LgWebOS.Models.Payload
{
	[DataContract]
	public class LaunchPoint
	{
		[DataMember(Name = "systemApp")]
		public bool SystemApp { get; set; }

		[DataMember(Name = "removable")]
		public bool Removable { get; set; }

		[DataMember(Name = "icons")]
		public List<string> Icons { get; set; }

		[DataMember(Name = "largeIcon")]
		public string LargeIcon { get; set; }

		[DataMember(Name = "bgImages")]
		public List<string> BackgroundImages { get; set; }

		[DataMember(Name = "relaunch")]
		public bool Relaunch { get; set; }

		[DataMember(Name = "userData")]
		public string UserData { get; set; }

		[DataMember(Name = "id")]
		public string Id { get; set; }

		[DataMember(Name = "title")]
		public string Title { get; set; }

		[DataMember(Name = "bgColor")]
		public string BackgroundColor { get; set; }

		[DataMember(Name = "iconColor")]
		public string IconColor { get; set; }

		[DataMember(Name = "appDescription")]
		public string AppDescription { get; set; }

		[DataMember(Name = "lptype")]
		public string LpType { get; set; }

		[DataMember(Name = "bgImage")]
		public string BackgroundImage { get; set; }

		[DataMember(Name = "unmovable")]
		public bool Unmovable { get; set; }

		[DataMember(Name = "icon")]
		public string Icon { get; set; }

		[DataMember(Name = "launchPointId")]
		public string LaunchPointId { get; set; }

		[DataMember(Name = "favicon")]
		public string Favicon { get; set; }

		[DataMember(Name = "imageForRecents")]
		public string ImageForRecents { get; set; }

		[DataMember(Name = "tileSize")]
		public string TileSize { get; set; }
	}
}
