using SimpleMqtt;

var client = SimpleMqttClient.CreateSimpleMqttClientForHiveMQ("MijnRobot");

client.OnMessageReceived += (sender, args) => 
{
    Console.WriteLine($"Bericht ontvangen; topic={args.Topic}; message={args.Message};");
};

await client.SubscribeToTopic("TestMQtt");

await client.PublishMessage("hello world", "TestMQtt");

string UserInput = Console.ReadLine();