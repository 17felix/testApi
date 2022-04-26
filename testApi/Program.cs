// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using System.Net.Http.Headers;
using testApi;

HttpClient client = new HttpClient();
var token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwibmFtZSI6InN0cmluZyIsInJvbGUiOlsiQWRtaW4iLCJVc2VyIl0sIm5iZiI6MTY1MDk3NzEyMiwiZXhwIjoxNjUwOTkxNTIyLCJpYXQiOjE2NTA5NzcxMjJ9._HQjWXA19KIEwpiThGgsdPw6CgxTsMdcCEyqBZ98KDE";
client.DefaultRequestHeaders.Authorization =
    new AuthenticationHeaderValue("Bearer", $"{token}");
Console.WriteLine(token.GetType());

try
{
    HttpResponseMessage loginUserResponse = await client.GetAsync("https://localhost:7115/UsersControllercs/login?userName=string&password=string.123A");
    HttpResponseMessage statusesResponse = await client.GetAsync("https://localhost:7115/statuses");
    loginUserResponse.EnsureSuccessStatusCode();
    statusesResponse.EnsureSuccessStatusCode();
    string loginUserResponseBody = await loginUserResponse.Content.ReadAsStringAsync();
    string StatusesResponseBody = await statusesResponse.Content.ReadAsStringAsync();
    // Above three lines can be replaced with new helper method below
    // Above three lines can be replaced with new helper method below
    // string responseBody = await client.GetStringAsync(uri);
    //Newtonsoft.Json.Linq.JObject.Parse(loginUserResponseBody);
    //Newtonsoft.Json.Linq.JArray.Parse(StatusesResponseBody);

    var statuses = JsonConvert.DeserializeObject<ICollection<StatusDTO>>(StatusesResponseBody);
    var login2 = JsonConvert.DeserializeObject<LoginUserDTO>(loginUserResponseBody);
    Console.WriteLine(loginUserResponseBody);
    Console.WriteLine(StatusesResponseBody);
    foreach (var status in statuses)
    {
        Console.WriteLine(status.Id + " " + status.Name);
    }
    Console.WriteLine(login2.Bara);
}
catch (HttpRequestException e)
{
    Console.WriteLine("\nException Caught!");
    Console.WriteLine("Message :{0} ", e.Message);
}

string json = @"{
  'Email': 'james@example.com',
  'Active': true,
  'CreatedDate': '2013-01-20T00:00:00Z',
  'Roles': [
    'User',
    'Admin'
  ]
}";

LoginUserDTO login = JsonConvert.DeserializeObject<LoginUserDTO>(json);
//StatusDTO status = JsonConvert.DeserializeObject<StatusDTO>(StatusesResponseBody);
//StatusDTO statusSerialize = JsonSerializer.DeserializeAsync<StatusDTO>(await json);
Console.WriteLine(login.Bara);
// james@example.com