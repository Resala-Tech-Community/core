using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using resala.core.Domain.Models;
using resala.core.Domain.Repositories;
using resala.core.Domain.Services;
using resala.core.Identity;
using resala.core.Persistence.Contexts;
using resala.core.Persistence.Repositories;
using resala.core.Services;

namespace resala.core
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

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "resala.core", Version = "v1" });
            });

            services.AddAutoMapper(typeof(Startup));


            services.AddDbContext<AppDbContext>();


            // Identity //

            services.AddIdentity<AppUser, IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>();


            services.AddScoped<IVolunteerService, VolunteerService>();
            services.AddScoped<IBasicService<MemberVolunteer>, BasicService<MemberVolunteer>>();
            services.AddScoped<IGenericReposirty<MemberVolunteer>, GenericRepositry<MemberVolunteer>>();




            services.AddScoped<IBranchService, BranchService>();
            services.AddScoped<IBasicService<Branch>, BasicService<Branch>>();
            services.AddScoped<IGenericReposirty<Branch>, GenericRepositry<Branch>>();

            services.AddScoped<IActivityServices, ActivityService>();
            services.AddScoped<IBasicService<Activity>, BasicService<Activity>>();
            services.AddScoped<IGenericReposirty<Activity>, GenericRepositry<Activity>>();


            services.AddScoped<ICommitteeService, CommitteeService>();
            services.AddScoped<IBasicService<Committee>, BasicService<Committee>>();
            services.AddScoped<IGenericReposirty<Committee>, GenericRepositry<Committee>>();

            services.AddScoped<ITrackerServicies, TrackerService>();
            services.AddScoped<IBasicService<Tracker>, BasicService<Tracker>>();
            services.AddScoped<IGenericReposirty<Tracker>, GenericRepositry<Tracker>>();

            services.AddScoped<ITrackRecordService, TrackRecordService>();
            services.AddScoped<IBasicService<TrackRecord>, BasicService<TrackRecord>>();
            services.AddScoped<IGenericReposirty<TrackRecord>, GenericRepositry<TrackRecord>>();

            //TODO: Support generic regestration later

            services.AddScoped<IUnitOfWork, UnitOfWork>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "resala.core v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}
