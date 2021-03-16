using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace NETCoreConsoleApp
{
    partial class Program
    {
        public class GreetingService : IGreetingService
        {
            private readonly ILogger<GreetingService> _log;
            private readonly IConfiguration _config;

            public GreetingService(ILogger<GreetingService> log, IConfiguration config)
            {
                _log = log;
                _config = config;
            }

            public void Run()
            {
                for (int i = 0; i < _config.GetValue<int>("LoopAmount"); i++)
                {
                    _log.LogInformation("Run # {runNumber}", i);
                }
            }
        }
    }
}
