using System;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Queue;
using System.Diagnostics;

namespace Resume.Server.Business.Handlers
{
    public static class MessageHandler
    {

        public static bool SendMessageToQueue(string message, string conn)
        {
            try
            {
                CloudQueue queue = GetQueue(conn);
                CloudQueueMessage queueMessage = new CloudQueueMessage(message);
                queue.AddMessage(queueMessage);
            }
            catch (Exception ex)
            {
                Trace.TraceInformation("exception: " + ex);
                return false;
            }
            return true;
        }

        private static CloudQueue GetQueue(string conn)
        {

            // Connecting to azure storage account and opening queue
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(conn);
            CloudQueueClient queueClient = storageAccount.CreateCloudQueueClient();
            CloudQueue queue = queueClient.GetQueueReference("messagequeue");

            queue.CreateIfNotExists();

            return queue;
        }
    }
}
