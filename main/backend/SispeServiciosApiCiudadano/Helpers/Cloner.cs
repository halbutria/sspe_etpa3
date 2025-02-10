using System.Text.Json;
using System.Text.Json.Serialization;

namespace SispeServiciosApiCiudadano.Helpers
{
    public static class Cloner
    {
        public static T DeepClone<T>(T obj)
        {
            var options = new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve,
                MaxDepth = 64
            };

            var jsonString = JsonSerializer.Serialize(obj, options);
            return JsonSerializer.Deserialize<T>(jsonString, options);
        }
    }
}
