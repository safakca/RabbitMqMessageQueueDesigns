// CONSUMER

using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

ConnectionFactory factory = new();
factory.Uri = new("amqps://..");

using IConnection connection = factory.CreateConnection();
using IModel channel = connection.CreateModel();

#region P2P (Point-to-Point) Message Desing

//string queueName = "example-p2p-queue";

//channel.QueueDeclare(queueName, durable: false, exclusive: false, autoDelete: false);

//EventingBasicConsumer consumer = new(channel);

//channel.BasicConsume(queue: queueName, autoAck: false, consumer: consumer);

//consumer.Received += (sender, e) =>
//{
//    Console.WriteLine(Encoding.UTF8.GetString(e.Body.Span));
//};

#endregion

#region Publish/Subscribe (Pub/Sub) Message Design

//string exchangeName = "example-pub-sub-exchange";

//channel.ExchangeDeclare(exchange: exchangeName, type: ExchangeType.Fanout);

//string queueName = channel.QueueDeclare().QueueName;

//channel.QueueBind(queue: queueName, exchange: exchangeName, routingKey: string.Empty);

//EventingBasicConsumer consumer = new(channel);

//channel.BasicConsume(queue: queueName, autoAck: false, consumer: consumer);

//byte[] message = Encoding.UTF8.GetBytes("I am pub-sub message design");

//channel.BasicPublish(exchange: exchangeName, routingKey: string.Empty, body: message);

//consumer.Received += (sender, e) =>
//{
//    Console.WriteLine(Encoding.UTF8.GetString(e.Body.Span));
//};

#endregion

#region Work Queue Message Design

//string queueName = "example-work-queue";

//channel.QueueDeclare(queue: queueName, durable: false, exclusive: false, autoDelete: false);

//EventingBasicConsumer consumer = new(channel);

//channel.BasicConsume(queue: queueName, autoAck: true, consumer: consumer);

//channel.BasicQos(prefetchCount: 1, prefetchSize: 0, global: false);

//consumer.Received += (sender, e) =>
//{
//    Console.WriteLine(Encoding.UTF8.GetString(e.Body.Span));
//};


#endregion

#region Request Response Message Design
//string queueName = "example-request-response-queue";
//channel.QueueDeclare(queue: queueName, durable: false, exclusive: false, autoDelete: false);
//string replyQueueName = channel.QueueDeclare().QueueName;

//EventingBasicConsumer consumer = new(channel);
//channel.BasicConsume(queue: replyQueueName, autoAck: true, consumer: consumer );
//consumer.Received += async (sender, e) =>
//{
//    Console.WriteLine(Encoding.UTF8.GetString(e.Body.Span));
//    byte[] responseMessage = Encoding.UTF8.GetBytes("Process Done!");  
//    IBasicProperties properties = e.BasicProperties;
//    IBasicProperties replyProperties = channel.CreateBasicProperties();
//    replyProperties.CorrelationId = properties.CorrelationId;
//    channel.BasicPublish(exchange: string.Empty, routingKey: properties.ReplyTo, basicProperties: replyProperties, body: responseMessage);
//};
#endregion
Console.Read();
