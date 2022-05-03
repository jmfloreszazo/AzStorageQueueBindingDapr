using System.Text.Json;
using Dapr.Client;
using PubSubDaprSample.Contracts;

namespace PubSubDarpSample.Publisher;

public class MessageService
{
    private readonly DaprClient _client;

    public MessageService()
    {
        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = false
        };
        _client = new DaprClientBuilder().UseJsonSerializationOptions(options).Build();
    }

    public async Task SendEventMessages(int numberOfActions, string outputbinding)
    {
        var objects = new List<SomeObject>();

        for (var i = 0; i < numberOfActions; i++)
        {
            var obj = createSomeObject();
            objects.Add(obj);
        }

        await PublishMessages(objects, outputbinding);
    }

    private SomeObject createSomeObject()
    {
        var guid = Guid.NewGuid().ToString();
        return new SomeObject
        {
            PropA = "Test A: " + guid,
            PropB = "Test B: " + guid
        };
    }

    private async Task PublishMessages(List<SomeObject> menssages, string outputbinding)
    {
        foreach (var menssage in menssages)
            await _client.InvokeBindingAsync(outputbinding, "create", menssage);
    }
}