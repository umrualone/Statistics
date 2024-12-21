using System.Text.Json.Serialization;

namespace Statistics.Application.Dtos.Resources
{
    public abstract class BaseResources
    {
        [JsonPropertyOrder(-1)]
        public Guid Id { get; set; }
    }
}