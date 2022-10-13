using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileWatching
{
    public class FileConsumerService : IFileConsumerService
    {
        ILogger<FileConsumerService> _logger;

        public FileConsumerService(ILogger<FileConsumerService> logger)
        {
            _logger = logger;
        }

        public async Task ConsumeFile(string pathToFile)
        {
            if(!File.Exists(pathToFile))
                return;

            _logger.LogInformation($"Starting read of {pathToFile}");

            using (StreamReader sr = File.OpenText(pathToFile))
            {
                string? s = null;
                int counter = 1;
                while ((s = await sr.ReadLineAsync()) != null)
                {
                    _logger.LogInformation($"Reading Line {counter} of the file {pathToFile}");
                    counter++;
                }
            }

            _logger.LogInformation($"Completed read of {pathToFile}");
        }
    }
}
