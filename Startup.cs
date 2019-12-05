using AutoMapper;
using Midleware.Donation.Domain.Repository;
using Midleware.Donation.Domain.Service;
using Midleware.Donation.Domain.Service.Contracts;
using Donation.Infra.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Midleware.Donation.Infra.Repository;

namespace Donation
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
            services.AddAutoMapper();
            services.AddMvc();

            services.AddTransient<IDonationService, DonationService>();
            services.AddTransient<IParticipantService, ParticipantService>();

            services.AddTransient<IDonationRepository, DonationRepository>();
            services.AddTransient<IParticipantRepository, ParticipantRepository>();
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

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
