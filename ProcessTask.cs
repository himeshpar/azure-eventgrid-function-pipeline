using Azure.Messaging.EventGrid;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace ProcessTaskFn
{
    public class ProcessTask
    {
        private readonly ILogger _logger;

        public ProcessTask(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<ProcessTask>();
        }

        [Function("ProcessTask")]
        public void Run([EventGridTrigger] EventGridEvent eventGridEvent)
        {
            _logger.LogInformation($"Processed EventGrid event: {eventGridEvent.Id}");
        }
    }
}
