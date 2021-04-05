using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace Abdelmneim.NoTenancy
{
    public class NoTenancyWebTestStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<NoTenancyWebTestModule>();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            app.InitializeApplication();
        }
    }
}