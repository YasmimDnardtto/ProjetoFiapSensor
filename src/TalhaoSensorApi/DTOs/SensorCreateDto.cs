using System;
using System.Text.Json.Serialization;
using TalhaoSensorApi.JsonConverters;

namespace TalhaoSensorApi.DTOs
{
    public class SensorCreateDto
    {
        public Guid TalhaoId { get; set; }
        public double Umidade { get; set; }
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly Data { get; set; }
        public double Temperatura { get; set; }
        public string? TipoTalhao { get; set; }
    }
}