using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;
namespace MOMSender
{
    class Producer
    {
        static void Main(string[] args)
        {
            // Create the factory, connection and channel
            // In this case the host is not local host, but a remote machine
            // where the MOM server is running, in our case @IP = 172.16.107.1
            var factory = new ConnectionFactory() { HostName = "172.16.107.1" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "queue1", durable: false,
                exclusive: false, autoDelete: false, arguments: null);
                string message = "Hello World!";
                var body = Encoding.UTF8.GetBytes(message);
                channel.BasicPublish(exchange: "", routingKey: "queue1",
                basicProperties: null, body: body);
                Console.WriteLine(" [x] Sent {0}", message);
            }
            Console.WriteLine(" Press [enter] to exit.");
            Console.ReadLine();
        }
    }
}
