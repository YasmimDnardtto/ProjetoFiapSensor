using System;
using System.Threading.Tasks;
using TalhaoSensorApi.Data;
using TalhaoSensorApi.DTOs;
using TalhaoSensorApi.Models;

namespace TalhaoSensorApi.Services
{
    public class SensorService
    {
        private readonly ApplicationDbContext _context;

        public SensorService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<RegistroSensor> CreateSensor(SensorCreateDto sensorDto)
        {
            // Converter DateOnly para DateTime usando meia-noite UTC
            var dateTime = sensorDto.Data.ToDateTime(new TimeOnly(0, 0));
            var registroSensor = new RegistroSensor
            {
                TalhaoId = sensorDto.TalhaoId.GetHashCode(),
                DataHora = DateTime.SpecifyKind(dateTime, DateTimeKind.Utc),
                TemperaturaValor = sensorDto.Temperatura,
                UmidadeValor = sensorDto.Umidade,
                StatusProcessamento = 1,
                EnumAlerta = null,
                DataProcessamento = null
            };

            _context.RegistroSensores.Add(registroSensor);
            await _context.SaveChangesAsync();

            return registroSensor;
        }
    }
}