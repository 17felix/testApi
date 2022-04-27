// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using System.Net.Http.Headers;
using testApi;

HttpClient client = new HttpClient();
var token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwibmFtZSI6InN0cmluZyIsInJvbGUiOlsiQWRtaW4iLCJVc2VyIl0sIm5iZiI6MTY1MDk3NzEyMiwiZXhwIjoxNjUwOTkxNTIyLCJpYXQiOjE2NTA5NzcxMjJ9._HQjWXA19KIEwpiThGgsdPw6CgxTsMdcCEyqBZ98KDE";

var apiKey = "d455bbf45b2acc31d57cb1ea046fcd77";
var cityName = "London";
var uriWeather = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}";

try
{
    var weather = await ExtensionMethods.GetClientRespnose<WeatherDto>(client, uriWeather);

    Console.WriteLine(weather);
}
catch (HttpRequestException e)
{
    Console.WriteLine("\nException Caught!");
    Console.WriteLine("Message :{0} ", e.Message);
}