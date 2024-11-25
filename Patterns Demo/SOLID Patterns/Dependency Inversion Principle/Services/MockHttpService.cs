using Patterns_Demo.SOLID_Patterns.Dependency_Inversion_Principle.Abstractions;
using System.Net.Http.Headers;

public class MockHttpService(IConnection connection)
{
    private readonly IConnection _connection = connection;

    public async Task<HttpResponseMessage> Request(string url, MediaTypeWithQualityHeaderValue opts)
    {
        return await _connection.Request(url, HttpMethod.Get.Method, new MediaTypeWithQualityHeaderValue("text/plain"));
    }
}
