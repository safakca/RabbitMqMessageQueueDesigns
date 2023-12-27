// PUBLISHER

using RabbitMQ.Client;
using System.Globalization;
using System.Text;

ConnectionFactory factory = new();
factory.Uri = new("amqps://..");

using IConnection connection = factory.CreateConnection();
using IModel channel = connection.CreateModel();


#region P2P (Point-to-Point) Message Desing

//string queueName = "example-p2p-queue";

//channel.QueueDeclare(queueName, durable: false, exclusive: false, autoDelete: false);

//byte[] message = Encoding.UTF8.GetBytes("I am p2p queue design");

//channel.BasicPublish(exchange: string.Empty, routingKey: queueName, body: message);

#endregion

#region Publish/Subscribe (Pub/Sub) Message Design

//string exchangeName = "example-pub-sub-exchange";

//channel.ExchangeDeclare(exchange: exchangeName, type: ExchangeType.Fanout);

//for (int i = 0; i < 100; i++)
//{
//    await Task.Delay(200);

//    byte[] message = Encoding.UTF8.GetBytes(i + " I am pub-sub message design ");

//    channel.BasicPublish(exchange: exchangeName, routingKey: string.Empty, body: message);
//}

#endregion

#region Work Queue Message Design

//string queueName = "example-work-queue";

//channel.QueueDeclare(queue: queueName, durable: false, exclusive: false, autoDelete: false);

//IBasicProperties properties = channel.CreateBasicProperties();
//properties.Persistent = true;

//for (int i = 0; i < 100; i++)
//{
//    await Task.Delay(200);

//    byte[] message = Encoding.UTF8.GetBytes(i + " I am Work Queue Message Design");

//    channel.BasicPublish(exchange: string.Empty, routingKey: queueName, body: message, basicProperties: properties);
//}

#endregion

#region Request Message Design
//string queueName = "example-request-response-queue";
//channel.QueueDeclare(queue: queueName, durable: false, exclusive: false, autoDelete: false);
//string replyQueueName = channel.QueueDeclare().QueueName;
//string correlationId = Guid.NewGuid().ToString();
//IBasicProperties properties = channel.CreateBasicProperties();
//properties.CorrelationId= correlationId;
//properties.ReplyTo = replyQueueName;
//byte[] body= Encoding.UTF8.GetBytes($"Request Message");
//channel.BasicPublish(exchange: string.Empty, routingKey: queueName, body: body, basicProperties: properties);

//EventingBasicConsumer consumer = new(channel);
//channel.BasicConsume(queue: replyQueueName, autoAck: true, consumer: consumer );
//consumer.Received += async (sender, e) =>
//{
//    if(e.BasicProperties.CorrelationId == correlationId)
//      Console.WriteLine($"Response= {Encoding.UTF8.GetString(e.Body.Span)}");
//};
#endregion

Console.Read();
