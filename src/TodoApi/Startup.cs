using System;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Framework.DependencyInjection;
namespace TodoApi
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
            app.UseWelcomePage();
            app.UseMvc();
        }

        public void ConfigureSevices(IServiceCollection services)
        {
            services.AddMvc();
        }
    }
}
