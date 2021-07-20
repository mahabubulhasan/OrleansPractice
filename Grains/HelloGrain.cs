using GrainInterfaces;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Grains
{
    public class HelloGrain: Orleans.Grain, IHello
    {
        private readonly ILogger<HelloGrain> logger;

        public HelloGrain(ILogger<HelloGrain> logger)
        {
            this.logger = logger;
        }

        public Task<string> SayHello(string greetings)
        {
            logger.LogInformation($"\n SayHello message received: greeting = '{greetings}'");
            return Task.FromResult($"\n Client said: '{greetings}', so HelloGrain says: Hello!");
        }
    }
}
