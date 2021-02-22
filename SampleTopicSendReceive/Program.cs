using System;

namespace SampleTopicSendReceive
{
	public class Program
	{
		public static void Main(string[] args)
		{
			//send message to topic
			Console.WriteLine("Sending a message to the Sales Performance topic...");
			SendMessage.SendPerformanceMessageAsync().GetAwaiter().GetResult();
			Console.WriteLine("Message was sent successfully.");

			//receive message from topic
			ReceiveMessage.MainAsync().GetAwaiter().GetResult();
		}
	}
}
