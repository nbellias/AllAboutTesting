using AllAboutTesting.MyWebAPI.Models;
using Newtonsoft.Json;
using RestSharp;
using FluentAssertions;

namespace AllAboutTesting.SimpleNUnitTests
{
    public class WebAPIUnitTests
    {
        private List<WeatherForecast> _weatherForecasts;
        private string _status;

        [SetUp]
        public void Setup()
        {
            var client = new RestClient("https://localhost:7018/");
            var request = new RestRequest("WeatherForecast", Method.Get);
            request.AddHeader("Accept", "application/json");
            request.RequestFormat = DataFormat.Json;

            var response = client.Execute(request);
            var statusCode = response.StatusCode.ToString();

            _weatherForecasts = JsonConvert.DeserializeObject<List<WeatherForecast>>(response.Content);
            _status = statusCode;
        }

        [Test]
        public void MyWebAPITest1()
        {
            Assert.AreEqual(_status, "OK");
        }

        [Test]
        public void MyWebAPITest2()
        {
            Assert.AreEqual(_weatherForecasts.Count, 5);
        }

        [Test]
        public void MyWebAPITest3()
        {
            string expectedJson = @"[
                              {
                                'date': '2022-07-24T08:21:46.8544505+03:00',
                                'temperatureC': 42,
                                'temperatureF': 107,
                                'summary': 'Freezing'
                              },
                              {
                                'date': '2022-07-25T08:21:46.8544642+03:00',
                                'temperatureC': 25,
                                'temperatureF': 76,
                                'summary': 'Bracing'
                              },
                              {
                                'date': '2022-07-26T08:21:46.8544647+03:00',
                                'temperatureC': 34,
                                'temperatureF': 93,
                                'summary': 'Hot'
                              },
                              {
                                'date': '2022-07-27T08:21:46.854465+03:00',
                                'temperatureC': 19,
                                'temperatureF': 66,
                                'summary': 'Freezing'
                              },
                              {
                                'date': '2022-07-28T08:21:46.8544653+03:00',
                                'temperatureC': 29,
                                'temperatureF': 84,
                                'summary': 'Chilly'
                              }
                            ]";
            var wl = JsonConvert.DeserializeObject<List<WeatherForecast>>(expectedJson);
            // Assert that 
            _weatherForecasts.Should().BeOfType(wl.GetType()).And.HaveCount(wl.Count);
        }

        [Test]
        public void MyWebAPITest4()
        {
            string expectedJson = $@"[
                              {{
                                'date': '{_weatherForecasts[0].Date:yyyy-MM-ddTHH:mm:ss.fffffffZ}',
                                'temperatureC': {_weatherForecasts[0].TemperatureC},
                                'temperatureF': {_weatherForecasts[0].TemperatureF},
                                'summary': '{_weatherForecasts[0].Summary}'
                              }},
                              {{
                                'date': '{_weatherForecasts[1].Date:yyyy-MM-ddTHH:mm:ss.fffffffZ}',
                                'temperatureC': {_weatherForecasts[1].TemperatureC},
                                'temperatureF': {_weatherForecasts[1].TemperatureF},
                                'summary': '{_weatherForecasts[1].Summary}'
                              }},
                              {{
                                'date': '{_weatherForecasts[2].Date:yyyy-MM-ddTHH:mm:ss.fffffffZ}',
                                'temperatureC': {_weatherForecasts[2].TemperatureC},
                                'temperatureF': {_weatherForecasts[2].TemperatureF},
                                'summary': '{_weatherForecasts[2].Summary}'
                              }},
                              {{
                                'date': '{_weatherForecasts[3].Date:yyyy-MM-ddTHH:mm:ss.fffffffZ}',
                                'temperatureC': {_weatherForecasts[3].TemperatureC},
                                'temperatureF': {_weatherForecasts[3].TemperatureF},
                                'summary': '{_weatherForecasts[3].Summary}'
                              }},
                              {{
                                'date': '{_weatherForecasts[4].Date:yyyy-MM-ddTHH:mm:ss.fffffffZ}',
                                'temperatureC': {_weatherForecasts[4].TemperatureC},
                                'temperatureF': {_weatherForecasts[4].TemperatureF},
                                'summary': '{_weatherForecasts[4].Summary}'
                              }},
                            ]";
            var wl = JsonConvert.DeserializeObject<List<WeatherForecast>>(expectedJson);
            // Assert that 
            _weatherForecasts.Should().BeEquivalentTo(wl);
        }
    }
}
