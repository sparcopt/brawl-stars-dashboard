using Newtonsoft.Json;

namespace Data.Services.Serialization
{
    public static class SerializerSettings
    {
        public static readonly JsonSerializerSettings JsonSerializerSettings = new JsonSerializerSettings
        {
            DateTimeZoneHandling = DateTimeZoneHandling.Utc,
            DateFormatString = "yyyyMMddTHHmmss.fffZ",
        };
    }
}
