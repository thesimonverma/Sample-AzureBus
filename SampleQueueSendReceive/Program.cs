using Microsoft.Azure.ServiceBus;
using System;
using System.Text;
using System.Threading.Tasks;

namespace SampleQueueSendReceive
{
	class Program
	{
		
		static void Main(string[] args)
		{
			///send message to queue
			Console.WriteLine("Sending a message to the Sales Messages queue...");
			SendMessage.SendSalesMessageAsync().GetAwaiter().GetResult();
			Console.WriteLine("Message was sent successfully.");

			//receive message from queue
			ReceiveMessage.ReceiveSalesMessageAsync().GetAwaiter().GetResult();
		}
    }
}
