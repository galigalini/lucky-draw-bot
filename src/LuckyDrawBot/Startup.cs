﻿using LuckyDrawBot.Models;
using LuckyDrawBot.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LuckyDrawBot
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddSingleton(Configuration.GetSection("Bot").Get<BotSettings>());
            services.AddSingleton<IDateTimeService, DateTimeService>();
            services.AddSingleton<IRandomService, RandomService>();
            services.AddSingleton<ICompetitionRepositoryService, CompetitionRepositoryService>();
            services.AddSingleton<ICompetitionService, CompetitionService>();
            services.AddSingleton<IActivityBuilder, ActivityBuilder>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseMvc();
        }
    }
}
