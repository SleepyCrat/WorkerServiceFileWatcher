namespace FileWatching;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;
    private readonly IMyFileWatcher _watcher;

    public Worker(ILogger<Worker> logger,IMyFileWatcher watcher)
    {
        _logger = logger;
        _watcher = watcher;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _watcher.Start();
        while (!stoppingToken.IsCancellationRequested)
        {

        }
    }
}
