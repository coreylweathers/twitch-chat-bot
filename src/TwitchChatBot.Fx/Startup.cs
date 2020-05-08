﻿using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Http;
using TwitchChatBot.Shared.Models;

[assembly: FunctionsStartup(typeof(TwitchChatBot.Fx.Startup))]
namespace TwitchChatBot.Fx
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddHttpClient(Constants.FX_HTTPCLIENT_NAME, 
                opts => 
                {
                    opts.DefaultRequestHeaders.Clear();

                    opts.BaseAddress = new System.Uri("https://hooks.zapier.com");
                });
        }
    }
}
