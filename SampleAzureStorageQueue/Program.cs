using System;

namespace SampleAzureStorageQueue
{
	class Program
	{
		public static void Main(string[] args)
		{
			//inserting in queue
			SendMessage.SendMessageToQueue().GetAwaiter().GetResult();

			//peeking in queue
			ReceiveMessage.PeekMessage().GetAwaiter().GetResult();

			//reading queue
			ReceiveMessage.GetMessages().GetAwaiter().GetResult();
		}
	}
}
