using MailingProject.Client.ViewModels;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Shared;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace MailingProject.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddTransient<ISendMailViewModel,SendMailViewModel>();
            builder.Services.AddTransient<MailDTO>();

            await builder.Build().RunAsync();
        }
    }
}
