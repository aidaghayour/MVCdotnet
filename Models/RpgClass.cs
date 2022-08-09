using System.Text.Json.Serialization;
namespace Udemydotnet.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Knights = 1,
        Mage=2,
        Cleric=3
    }
}