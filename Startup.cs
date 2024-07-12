using MoodRadio.Repositories;
using MoodRadio.Services;
using MoodRadio.Models;
using MoodRadio.DB;

namespace MoodRadio
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
            services.AddCors();

            services.AddControllers();

            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            PostgresContext.ConnectionString = Configuration.GetConnectionString("Database");

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepository<User>, UserRepository<User>>();
            services.AddDbContext<PostgresContext>(options =>
                Configuration.GetConnectionString("Database"));
                // options.UseNpgsql(Constants.DB));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod().WithOrigins("localhost:3000"));
            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}