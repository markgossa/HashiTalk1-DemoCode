using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace AzureDurableFunctionsDemo1.Functions
{
    public class TimeGreeting
    {
        [FunctionName("TimeGreeting")]
        public static string TimeGreetingMethod([ActivityTrigger] string name, ILogger log)
        {
            log.LogInformation($"Saying hello to {name}.");
            string output = SayHello(GetGreeting(), name);
            return output;
        }

        public static string SayHello(string greeting, string name)
        {
            return $"{greeting} {name}!";
        }

        public static string GetGreeting()
        {
            var dateTimeHour = DateTime.Now.TimeOfDay.Hours;

            if(dateTimeHour < 12)
            {
                return "Good morning";
            }
            else if (dateTimeHour > 12 && dateTimeHour < 18)
            {
                return "Good afternoon";
            }
            else if (dateTimeHour > 18 && dateTimeHour < 21)
            {
                return "Good evening";
            }
            else
            {
                return "Good night";
            }
        }
    }
}
