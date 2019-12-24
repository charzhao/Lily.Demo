using JsonPatchSample.Models;
using Microsoft.AspNetCore.JsonPatch;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Xunit;

namespace Lily.Demo.JsonPatch.IntergationTest
{
    public class UnitTest1: IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        private readonly HttpClient _client;
        public UnitTest1(CustomWebApplicationFactory<Startup> factory)
        {
            _client = factory.CreateClient();
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
        [Fact]
        public async System.Threading.Tasks.Task Test1Async()
        {
            var patchDocument = new JsonPatchDocument<Product>();
            patchDocument.Test(_ => _.ProductName, "9.8");
            var a = patchDocument.ToString();

            var stringContent = new StringContent(JsonConvert.SerializeObject(patchDocument), Encoding.UTF8, "application/json");

            // The endpoint or route of the controller action.
            var httpResponse = await _client.PatchAsync("/jsonpatch/JsonPatchForProduct", stringContent);
        }
    }
}
