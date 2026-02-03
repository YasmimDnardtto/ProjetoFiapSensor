using System;

namespace TalhaoSensorApi.Models
{
    public class TalhaoHistoricoStatus
    {
        public int Id { get; set; }
        public int TalhaoId { get; set; }
        public DateTime DataHora { get; set; }
        public string? EnumAlerta { get; set; }
    }
}