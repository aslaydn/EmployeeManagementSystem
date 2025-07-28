using System.Text.Json;

namespace ClientLibrary.Helpers
{
    public static class Serializations
    {
        public static string SerializeObj<T>(T modelObject) => JsonSerializer.Serialize(modelObject);
        public static T? DeserializeJsonString<T>(string jsonString)
        {
            if (string.IsNullOrWhiteSpace(jsonString))
            {
                return default;
            }
            return JsonSerializer.Deserialize<T>(jsonString, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }
        public static IList<T> DeserializeJsonStringList<T>(string jsonString)
        {
            if (string.IsNullOrWhiteSpace(jsonString))
            {
                return new List<T>();
            }

            return JsonSerializer.Deserialize<IList<T>>(jsonString, new JsonSerializerOptions { PropertyNameCaseInsensitive = true }) ?? new List<T>();
        }
    }
}
