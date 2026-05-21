using Azure.Messaging.ServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureQeueue.Sender
{
    public static class AzureQueueSender
    {
        private static string QueueuConnectionString = "UseYourConnectionStringHere";

        private static string QueueuName = "demosenderqueue";

        private static string Message = "Welcome to microsoft Azure learning Service Bus Queue";


        public  static async Task SendMessage(string usertextMessage)
        {
            try
            {
                

                Console.WriteLine("Sending Message");
                var client = new ServiceBusClient(QueueuConnectionString);
                var sendder = client.CreateSender(QueueuName);
                var busMessage = new ServiceBusMessage(usertextMessage.ToString());
                await sendder.SendMessageAsync(busMessage);
                Console.WriteLine($"  Sent:{usertextMessage}");
                //foreach (var character in Message)
                //{
                //    var busMessage = new ServiceBusMessage(character.ToString());
                //    await sendder.SendMessageAsync(busMessage);
                //    Console.WriteLine($"  Sent:{character}");
                //}
                await sendder.CloseAsync();
                Console.WriteLine("Message Sent Success");
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}
