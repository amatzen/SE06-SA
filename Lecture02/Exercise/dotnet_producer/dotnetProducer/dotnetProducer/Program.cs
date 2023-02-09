using System;
using Confluent.Kafka;

namespace DotnetKafkaProducer
{
    class Program
    {
        static void Main(string[] args)
        {
            // the bootstrap server is the address of the kafka broker, i.e. the docker container. Here you can specify multiple brokers 
            // separated by a comma to enable load balancing and fault tolerance.
            var config = new ProducerConfig { BootstrapServers = "kafka1:9092" };

            using (var producer = new ProducerBuilder<Null, string>(config).Build())
            {
                Console.WriteLine("A kafka message");

                while (true)
                {
                    try
                    {
                        var message = "message " + DateTime.Now;
                        var result = producer.ProduceAsync("example_topic", new Message<Null, string> { Value = message }).Result;

                        Console.WriteLine($"Message '{message}' sent to partition {result.Partition} with offset {result.Offset}");
                    }
                    catch (ProduceException<Null, string> e)
                    {
                        Console.WriteLine($"Delivery failed: {e.Error.Reason}");
                    }
                    System.Threading.Thread.Sleep(3000);
                }
            }
        }
    }
}