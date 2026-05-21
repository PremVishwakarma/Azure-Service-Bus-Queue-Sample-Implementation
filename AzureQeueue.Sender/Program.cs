// See https://aka.ms/new-console-template for more information
using AzureQeueue.Sender;

Console.WriteLine("Please enter any message to send");
string messageToSent = Console.ReadLine();
await AzureQueueSender.SendMessage(messageToSent);

