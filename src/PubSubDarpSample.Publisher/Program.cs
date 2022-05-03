using PubSubDarpSample.Publisher;

var pubService = new MessageService();
await pubService.SendEventMessages(2, "azurequeueoutput");
