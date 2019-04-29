﻿using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace WebJobDemo
{
    public class Functions
    {
        public static void ProcessQueueMessage([QueueTrigger("queue")] string message, ILogger logger)
        {
            logger.LogInformation("DAVED " + message);
        }
    }
}
