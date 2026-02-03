# Talhão Sensor API

## Overview
The Talhão Sensor API is a RESTful API designed to handle sensor data for agricultural talhões. It allows users to submit sensor readings, which are then stored in a database for further analysis and monitoring.

## Features
- POST endpoint to receive sensor data.
- Data models for sensor readings and historical status.
- Integration with a database for persistent storage.

## Project Structure
```
talhao-sensor-api
├── src
│   └── TalhaoSensorApi
│       ├── Controllers
│       │   └── SensorController.cs
│       ├── Models
│       │   ├── RegistroSensor.cs
│       │   ├── TalhaoHistoricoStatus.cs
│       │   └── Talhao.cs
│       ├── Data
│       │   └── ApplicationDbContext.cs
│       ├── DTOs
│       │   └── SensorCreateDto.cs
│       ├── Services
│       │   └── SensorService.cs
│       ├── Program.cs
│       ├── appsettings.json
│       └── TalhaoSensorApi.csproj
├── .gitignore
├── Dockerfile
└── README.md
```

## Setup Instructions
1. Clone the repository:
   ```
   git clone <repository-url>
   ```
2. Navigate to the project directory:
   ```
   cd talhao-sensor-api
   ```
3. Restore the dependencies:
   ```
   dotnet restore
   ```
4. Update the `appsettings.json` file with your database connection string.
5. Run the application:
   ```
   dotnet run
   ```

## Usage
To submit sensor data, send a POST request to the `/api/sensor` endpoint with the following JSON body:
```json
{
  "talhaoId": "string",
  "umidade": "float",
  "data": "string",
  "temperatura": "float",
  "tipoTalhao": "string"
}
```

## License
This project is licensed under the MIT License. See the LICENSE file for details.