using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IHostBuilder hostBuilder = new HostBuilder();
hostBuilder.ConfigureServices(services =>
{
services.AddHostedService<MyService>();
});

using (IHost host = hostBuilder.Build())
{
await host.StartAsync();
}

public class MyService : IHostedLifecycleService
{
    public Task StartingAsync(CancellationToken cancellationToken) => /* add logic here */ Task.CompletedTask;
    public Task StartAsync(CancellationToken cancellationToken) => /* add logic here */ Task.CompletedTask;
    public Task StartedAsync(CancellationToken cancellationToken) => /* add logic here */ Task.CompletedTask;
    public Task StopAsync(CancellationToken cancellationToken) => /* add logic here */ Task.CompletedTask;
    public Task StoppedAsync(CancellationToken cancellationToken) => /* add logic here */ Task.CompletedTask;
    public Task StoppingAsync(CancellationToken cancellationToken) => /* add logic here */ Task.CompletedTask;
}


//The full lifecycle:

//IHostLifetime.WaitForStartAsync
//IHostedLifecycleService.StartingAsync
//IHostedService.Start
//IHostedLifecycleService.StartedAsync
//IHostApplicationLifetime.ApplicationStarted
//IHostedLifecycleService.StoppingAsync
//IHostApplicationLifetime.ApplicationStopping
//IHostedService.Stop
//IHostedLifecycleService.StoppedAsync
//IHostApplicationLifetime.ApplicationStopped
//IHostLifetime.StopAsync