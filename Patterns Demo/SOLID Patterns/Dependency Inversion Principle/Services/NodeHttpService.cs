﻿using Patterns_Demo.SOLID_Patterns.Dependency_Inversion_Principle.Abstractions;
using System.Net.Http.Headers;

public class NodeHttpService(IConnection connection)
{
    private readonly IConnection _connection = connection;

    public async Task<HttpResponseMessage> Request(string url)
    {
        return await _connection.Request(url, HttpMethod.Get.Method, new MediaTypeWithQualityHeaderValue("application/json"));
    }
}
