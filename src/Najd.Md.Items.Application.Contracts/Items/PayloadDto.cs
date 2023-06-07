using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Najd.Md.Items
{
    public partial class PayloadDto
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("hidden")]
        public bool Hidden { get; set; }

        [JsonProperty("index")]
        public long? Index { get; set; }

        [JsonProperty("hint")]
        public string Hint { get; set; }

        [JsonProperty("requiredLength")]
        public int? RequiredLength { get; set; }

        [JsonProperty("maximumLength")]
        public int? MaximumLength { get; set; }

        [JsonProperty("minimumLength")]
        public int? MinimumLength { get; set; }

        [JsonProperty("regularExpression")]
        public string RegularExpression { get; set; }
    }
}
