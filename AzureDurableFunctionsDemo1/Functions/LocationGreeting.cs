using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace AzureDurableFunctionsDemo1.Functions
{
    public class LocationGreeting
    {
        [FunctionName("LocationGreeting")]
        public static string LocationGreetingMethod([ActivityTrigger] string location, ILogger log)
        {
            log.LogInformation($"Saying hello to {location}.");
            return $"Hello from {location}!";
        }
    }
}
