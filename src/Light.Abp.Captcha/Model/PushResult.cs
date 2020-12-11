using Newtonsoft.Json;

namespace Light.Abp.JPush
{
    public class PushResult
    {
        [JsonProperty("sendno")]
        public string SendNo { get; set; }

        [JsonProperty("msg_id")]
        public string MsgId { get; set; }

        [JsonProperty("error")]
        public PushError Error { get; set; }
    }

    public class PushError
    {
        public int Code { get; set; }
        public string Message { get; set; }

        public override string ToString()
        {
            return $"{Code}:{Message}";
        }
    }
}


