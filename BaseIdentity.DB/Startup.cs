using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace BaseIdentity.DB
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
            => services.AddDbContext<ApiContext>();

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            this.Configure(app, env);
        }
    }
}
