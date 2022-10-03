using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressStore.Infrastructure.Modules
{
    public interface IModuleInitializer
    {
        void ConfigureServices(IServiceCollection serviceCollection);

        void Configure(IApplicationBuilder app, IWebHostEnvironment env);
    }
}
