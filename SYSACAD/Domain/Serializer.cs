using System.Text;
using System.Text.Json;

namespace Domain
{
    internal static class Serialize
    {
        internal static string SerializarAJson<T>(T objeto)
        {
            JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();
            jsonSerializerOptions.WriteIndented = true;

            return JsonSerializer.Serialize(objeto, jsonSerializerOptions);
        }

        internal static T? DeserializarDesdeJson<T>(string ruta)
        {
            string objetoJson = File.ReadAllText(ruta);

            T? objeto = JsonSerializer.Deserialize<T>(objetoJson);

            return objeto;
        }
    }
}
