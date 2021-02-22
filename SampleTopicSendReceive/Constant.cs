using System;
using System.Collections.Generic;
using System.Text;

namespace SampleTopicSendReceive
{
	public class Constant
	{
		//change Shared access policy and queue name from azure bus service
		public const string ServiceBusConnectionString = "dummyconn";
		public const string TopicName = "mytopic";
		public const string SubscriptionName = "topicsubs1";
	}
}
