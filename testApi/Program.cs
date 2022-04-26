// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using System.Net.Http.Headers;
using testApi;

HttpClient client = new HttpClient();
var token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwibmFtZSI6InN0cmluZyIsInJvbGUiOlsiQWRtaW4iLCJVc2VyIl0sIm5iZiI6MTY1MDk3NzEyMiwiZXhwIjoxNjUwOTkxNTIyLCJpYXQiOjE2NTA5NzcxMjJ9._HQjWXA19KIEwpiThGgsdPw6CgxTsMdcCEyqBZ98KDE";
client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", $"{token}");
var uriLogin = "https://localhost:7115/UsersControllercs/login?userName=string&password=string.123A";
var uriStatus = "https://localhost:7115/statuses";
string COUNTRY_DOMAIN = "services.rappi.co.cr";
var uriOther = $"https://{COUNTRY_DOMAIN}/api/v2/restaurants-integrations-public-api/menu";
var uriTest = "https://microservices.dev.rappi.com";

try
{
    var login = await ExtensionMethods.GetClientRespnose<LoginUserDTO>(client, uriLogin);
    var statuses = await ExtensionMethods.GetClientRespnose<ICollection<StatusDTO>>(client, uriStatus);
    /*var statusesResponseBody = await ExtensionMethods.GetClientRespnose(client, uriStatus);
    var otherResponseBody = await ExtensionMethods.GetClientRespnose(client, uriOther);

    var statuses = JsonConvert.DeserializeObject<ICollection<StatusDTO>>(statusesResponseBody);*/
    /*    var other = JsonConvert.DeserializeObject<LoginUserDTO>(otherResponseBody);*/

    // Console.WriteLine(loginUserResponseBody);
    //Console.WriteLine(statusesResponseBody);
    foreach (var status in statuses)
    {
        Console.WriteLine(status.Id + " " + status.Name);
    }
    Console.WriteLine(login.Bara);
}
catch (HttpRequestException e)
{
    Console.WriteLine("\nException Caught!");
    Console.WriteLine("Message :{0} ", e.Message);
}