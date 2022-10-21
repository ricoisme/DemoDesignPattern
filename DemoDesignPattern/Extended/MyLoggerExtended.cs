using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDesignPattern.Extended
{
    public sealed class MyLoggerExtended : IMyLogger
    {
        private readonly IMyLogger _logger;

        public MyLoggerExtended(IMyLogger logger)
        {
            _logger = logger;
        }
        void IMyLogger.Log(string message)
        {
            _logger.Log($"StartTime: {DateTime.UtcNow}");

            _logger.Log(message);

            _logger.Log($"EndTime: {DateTime.UtcNow}");
        }
    }
}
