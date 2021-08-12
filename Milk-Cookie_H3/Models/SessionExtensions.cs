using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Milk_Cookie_H3.Models
{
    // This static class represents SessionExtensions!
    public static class SessionExtensions
    {
        // JSON storage extension to serialize objects!
        public static void SetObjectAsJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        // JSON storage extension to deserialize objects!
        public static T GetObjectFromJson<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }
}
