using Microsoft.Azure.ServiceBus;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SampleQueueSendReceive
{
	public class SendMessage
	{
        const string ServiceBusConnectionString = Constant.ServiceBusConnectionString;
        const string QueueName = Constant.QueueName;
        static IQueueClient queueClient;
        public static async Task SendSalesMessageAsync()
        {
            // Create a Queue Client here
            queueClient = new QueueClient(ServiceBusConnectionString, QueueName);
            // Send messages.
            try
            {
                // Create and send a message here
                string messageBody = $"$10,000 order for bicycle parts from retailer Adventure Works.";
                var message = new Message(Encoding.UTF8.GetBytes(messageBody));
                Console.WriteLine($"Sending message: {messageBody}");
                await queueClient.SendAsync(message);
            }
            catch (Exception exception)
            {
                Console.WriteLine($"{DateTime.Now} :: Exception: {exception.Message}");
            }

            // Close the connection to the queue here
            await queueClient.CloseAsync();
        }
    }
}
