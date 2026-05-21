using Azure.Messaging.ServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureQeueue.Receiver
{
    public static class AzureQueueReceiver
    {
        private static string QueueuConnectionString = "Endpoint=sb://learnazureservicebus.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=7MleXuI+598HvPGdzimr+XciJs141wcdh+ASbCpnj/A=";

        private static string QueueuName = "demosenderqueue";


        public static async Task ReceiveMessage()
        {
            var client = new ServiceBusClient(QueueuConnectionString);

            var receiver = client.CreateReceiver(queueName: QueueuName);

            Console.WriteLine("Received Message");

            var message = await receiver.ReceiveMessageAsync();

            if (message != null)
            {
                Console.WriteLine("You have some pending messages...");
                Console.Write(message.Body.ToString());
                await receiver.CompleteMessageAsync(message);
            }
            await receiver.CloseAsync();
        }
    }
}
