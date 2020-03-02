using System.Runtime.Serialization;

namespace InnerCore.Api.LgWebOS.Models.Payload
{
    [DataContract]
	public class SystemInfoPayload : ReturnValuePayload
	{
        [DataMember(Name = "product_name")]
        public string ProductName { get; set; }

        [DataMember(Name = "model_name")]
        public string ModelName { get; set; }

        [DataMember(Name = "sw_type")]
        public string SoftwareType { get; set; }

        [DataMember(Name = "major_ver")]
        public string MajorVersion { get; set; }

        [DataMember(Name = "minor_ver")]
        public string MinorVersion { get; set; }

        [DataMember(Name = "country")]
        public string Country { get; set; }

        [DataMember(Name = "country_group")]
        public string CountryGroup { get; set; }

        [DataMember(Name = "device_id")]
        public string DeviceId { get; set; }

        [DataMember(Name = "ignore_disable")]
        public string IgnoreDisable { get; set; }

        [DataMember(Name = "eco_info")]
        public string EcoInfo { get; set; }

        [DataMember(Name = "config_key")]
        public string ConfigurationKey { get; set; }

        [DataMember(Name = "language_code")]
        public string LanguageCode { get; set; }
	}
}
