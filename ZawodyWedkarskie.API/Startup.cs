using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using ZawodyWedkarskie.API.Data;

namespace ZawodyWedkarskie.API
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
            services.AddDbContext<ZawodyWedkarskieContext>(x => x.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddControllers();
            // services.AddCors(options =>
            //     {
            //         options.AddPolicy("Cors",
            //         builder =>
            //         {
            //             //builder.WithOrigins("http://localhost:4200")
            //             builder.AllowAnyOrigin()
            //                                 .AllowAnyHeader()
                                        
            //                                 .AllowAnyMethod();
            //         });
            //     });
            services.AddScoped<IAuthRepository, AuthRepository>();
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Configuration.GetSection("AppSettings:Token").Value)),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });
            // services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            //             .AddJwtBearer(o => {
            //         o.TokenValidationParameters = new TokenValidationParameters
            //         {
            //             ValidateIssuerSigningKey = true,
            //             IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Configuration.GetSection("AppSettings:Token").Value)),
            //             ValidateIssuer = false,
            //             ValidateAudience = false
            //         };
            //     });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
             app.UseCors(x => x
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
            //app.UseCors("Cors");
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
