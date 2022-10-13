using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileWatching
{
    public interface IFileConsumerService
    {
        public Task ConsumeFile(string pathToFile); 
    }
}
