using System;
using System.Reflection;
using James.Blogs.Business.Extensions;
using Microsoft.OpenApi.Models;

namespace James.Blogs.API
{
    public class Startup
    {

        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            Configuration = configuration;
            Env = env;
        }
        public IConfiguration Configuration { get; }
        public IWebHostEnvironment Env { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddApiCore(Configuration, Env);
            var migrationsAssembly = typeof(Startup).GetTypeInfo()?.Assembly?.GetName()?.Name;
            if (migrationsAssembly != null)
            {
                services.AddCoreService(Configuration, migrationsAssembly);
                services.AddScopedService(Configuration, migrationsAssembly);
            }
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.EnvironmentName == "development")
            {
                app.UseDeveloperExceptionPage();
            }

            var pathBase = "/api";
            app.UsePathBase(pathBase);
            app.UseSwagger(options =>
                 {

                     options.PreSerializeFilters.Add((swagger, httpReq) =>
                     {
                         var serverUrl = $"{httpReq.Scheme}s://{httpReq.Host.Value}{pathBase}";
                         swagger.Servers = new List<OpenApiServer> { new OpenApiServer { Url = serverUrl } };
                     });
                 });
            app.UseSwaggerUI();
        }
    }
}

