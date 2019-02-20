using Xunit;
using AzureDurableFunctionsDemo1.Functions;

namespace AzureDurableFunctionsDemo1.Tests
{
    public class AzureDurableFunctionsDemo1Tests
    {
        [Fact]
        public void TestSayHello()
        {
            string output = TimeGreeting.SayHello("Good evening", "Joe");
            string correctOutput = "Good evening Joe!";
            Assert.Equal(correctOutput, output);
        }
    }
}
