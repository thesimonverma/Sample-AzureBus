using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Azure.Storage.Queues;

namespace SampleAzureStorageQueue
{
	public class SendMessage
	{
		public static string ConnectionString = Constant.ConnectionString;

		public static async Task SendMessageToQueue()
		{
			QueueClient queue = new QueueClient(ConnectionString, "storagequeue");
			//create if Queue doesnot exists
			await queue.CreateIfNotExistsAsync();
			if (await queue.ExistsAsync())
			{
				//send message to Queue
				await queue.SendMessageAsync(string.Format("This is test message to queue at {0}", DateTime.UtcNow));
				Console.WriteLine("Message added to queue");
			}
			else
			{
				Console.WriteLine("Unable to write on queue");
			}
		}
	}
}
