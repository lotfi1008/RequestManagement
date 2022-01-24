using RequestManagement.Core.Domain.WeatherForecasts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RequestManagement.Core.Domain.WeatherForecasts.Services
{
    public interface IRandomForecastsGenerator
    {
        List<WeatherForecast> Execute();
    }
}
