using System;

namespace TalhaoSensorApi.Models
{
    public class RegistroSensor
    {
        public int Id { get; set; }
        public int TalhaoId { get; set; }
        public DateTime DataHora { get; set; }
        public double TemperaturaValor { get; set; }
        public double UmidadeValor { get; set; }
        public int StatusProcessamento { get; set; }
        public string? EnumAlerta { get; set; }
        public DateTime? DataProcessamento { get; set; }
    }
}