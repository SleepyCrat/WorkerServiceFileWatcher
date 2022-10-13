using FileWatching;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();
        services.AddSingleton<IMyFileWatcher,MyFileWatcher>();
        services.AddScoped<IFileConsumerService,FileConsumerService>();
        
    })
    .Build();

await host.RunAsync();
