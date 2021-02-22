using Microsoft.Azure.ServiceBus;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SampleTopicSendReceive
{
	public class SendMessage
	{
        const string ServiceBusConnectionString = Constant.ServiceBusConnectionString;
        const string TopicName = Constant.TopicName;
        static ITopicClient topicClient;

        public static async Task SendPerformanceMessageAsync()
        {
            // Create a Topic Client here
            topicClient = new TopicClient(ServiceBusConnectionString, TopicName);
            // Send messages.
            try
            {
                // Create and send a message here
                string messageBody = $"Test topic message";
                var message = new Message(Encoding.UTF8.GetBytes(messageBody));
                Console.WriteLine($"Sending message: {messageBody}");
                await topicClient.SendAsync(message);
            }
            catch (Exception exception)
            {
                Console.WriteLine($"{DateTime.Now} :: Exception: {exception.Message}");
            }

            // Close the connection to the topic here
            await topicClient.CloseAsync();
        }
    }
}
