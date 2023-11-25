using System;
using James.Blogs.Repository.MongoInfrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;

namespace James.Blogs.Business.Extensions
{
    public static class StartupExtensions
    {
        public static void AddCoreService(
           this IServiceCollection services, IConfiguration Configuration, string migrationsAssembly)
        {
            services.AddSingleton<IMongoDb>(u =>
            {
                var mongoUrl = Configuration["Mongo"];
                var mongoDb = (new MongoClient(mongoUrl)).GetDatabase(new MongoUrl(mongoUrl).DatabaseName);
                return new MongoDb(mongoDb);
            });
        }
        public static void AddScopedService(
            this IServiceCollection services, IConfiguration Configuration, string migrationsAssembly)
        {
            //Service
            // var subScriber = ConnectionMultiplexer.Connect(Configuration["Redis"]);
            // services.AddSingleton<ISubscriber>(subScriber.GetSubscriber());
            // services.AddScoped<IRedisPublisher, RedisPublisher>();


        }
    }
}
