using Confluent.Kafka;

var config = new ConsumerConfig
{
    BootstrapServers = "localhost:9092",
    GroupId = "temperature-group",
    AutoOffsetReset = AutoOffsetReset.Earliest
};

using var consumer =
    new ConsumerBuilder<Ignore, string>(config)
    .Build();

consumer.Subscribe("Temperature_topic");

Console.WriteLine("Starting consumer...");

while (true)
{
    var result = consumer.Consume();

    Console.WriteLine(
        $"Received: {result.Message.Value} | " +
        $"Partition: {result.Partition} | " +
        $"Offset: {result.Offset}");
}
