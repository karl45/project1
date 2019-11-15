using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using aspnetfirst.Controllers;
using aspnetfirst.Data;
using aspnetfirst.Models;
using aspnetfirst.IRepositories;
using aspnetfirst.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using aspnetfirst.Repositories;

namespace aspnetfirst
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<BetContext>(options =>
            {
                options.UseSqlite("Filename=1XBET.db");
            });
            services.AddMvc();
            services.AddRouting();
            services.AddScoped<PlayerServices>();
            services.AddScoped<TeamServices>();
            services.AddScoped<CoachServices>();
            services.AddScoped<LeagueServices>();
            services.AddScoped<UserServices>();
            services.AddScoped<ScoreStatisticServices>();
            services.AddScoped<MatchServices>();
            services.AddScoped<IPlayerRepository,PlayerRepository>();
            services.AddScoped<IteamRepository, TeamRepository>();
            services.AddScoped<ICoachRepository, CoachRepository>();
            services.AddScoped<ILeagueRepository, LeagueRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IScoreStatisticRepository, ScoreStatisticRepository>();
            services.AddScoped<IMatchRepository,MatchRepository>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Users}/{action=WatchUsers}/{id?}");
            });
            app.UseStaticFiles();
            
        }
    }
}
