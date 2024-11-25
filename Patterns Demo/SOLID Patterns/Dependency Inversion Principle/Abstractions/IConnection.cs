using System.Net.Http.Headers;

namespace Patterns_Demo.SOLID_Patterns.Dependency_Inversion_Principle.Abstractions;

public interface IConnection
{
    public Task<HttpResponseMessage> Request(string url, string type, MediaTypeWithQualityHeaderValue opts,
            HttpContent? content = null);
}
