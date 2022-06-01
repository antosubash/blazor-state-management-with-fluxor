using Fluxor;
using FluxorWithBlazor.Model;

namespace FluxorWithBlazor.State.Weather
{
    [FeatureState]
    public class WeatherState
    {
        private WeatherState()
        {
        }
        public bool IsLoading { get; }
        public IEnumerable<WeatherForecast> Forecasts { get; }

        public WeatherState(bool isLoading, IEnumerable<WeatherForecast> forecasts)
        {
            IsLoading = isLoading;
            Forecasts = forecasts;
        }
    }
}