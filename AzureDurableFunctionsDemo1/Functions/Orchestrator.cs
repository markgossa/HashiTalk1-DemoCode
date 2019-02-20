using Microsoft.Azure.WebJobs;
using System.Threading.Tasks;
using AzureDurableFunctionsDemo1.Models;

namespace AzureDurableFunctionsDemo1.Functions
{
    public class Orchestrator
    {
        [FunctionName("Orchestrator")]
        public static async Task<string> RunOrchestrator(
            [OrchestrationTrigger] DurableOrchestrationContext context)
        {
            var userInfo = context.GetInput<UserInfo>();

            var timeGreeting = await context.CallActivityAsync<string>("TimeGreeting", userInfo.Name);
            var locationGreeting = await context.CallActivityAsync<string>("LocationGreeting", userInfo.Location);

            string output = $"{timeGreeting} {locationGreeting}";

            return output;
        }
    }
}
