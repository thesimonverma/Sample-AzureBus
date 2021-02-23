using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Azure.Storage.Queues;
using Azure.Storage.Queues.Models;

namespace SampleAzureStorageQueue
{
	public class ReceiveMessage
	{
		public static string ConnectionString = Constant.ConnectionString;

		public static async Task GetMessages()
		{
			QueueClient queueClient = new QueueClient(ConnectionString, "storagequeue");

			//check if queue exists
			if (await queueClient.ExistsAsync())
			{
				var queueMessages = await queueClient.ReceiveMessagesAsync(Constant.Max);
				foreach (var mess in queueMessages.Value)
				{
					Console.WriteLine(string.Format("Messages Id:{0} read from Queue", mess.MessageId));
					await queueClient.DeleteMessageAsync(mess.MessageId, mess.PopReceipt);
				}
			}
		}

		public static async Task PeekMessage()
		{
			QueueClient queueClient = new QueueClient(ConnectionString, "storagequeue");

			//check if queue exists
			if (await queueClient.ExistsAsync())
			{
				var peekedMessages = await queueClient.PeekMessagesAsync(Constant.Max);
				foreach (var mess in peekedMessages.Value)
				{
					Console.WriteLine(string.Format("Messages Id: {0} peeked from Queue", mess.MessageId));
				}
			}
		}
	}
}
