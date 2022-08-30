namespace Dolores
{
	using System;
	using System.Collections.Generic;
	using System.IO;
	using System.Linq;
	using System.Reflection;
	using System.Threading.Tasks;
	using Application.UseCases;
	using DataAccess;
	using Dolores;
	using Dolores.Config;
	using Dolores.Extensions;
	//using Dolores.Extensions;
	using Implementation;
	using Implementation.Logging;
	using Microsoft.AspNetCore.Builder;
	using Microsoft.AspNetCore.Hosting;
	using Microsoft.AspNetCore.Http;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.Extensions.Configuration;
	using Microsoft.Extensions.DependencyInjection;
	using Microsoft.Extensions.Hosting;
	using Microsoft.Extensions.Logging;
	using Microsoft.OpenApi.Models;

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
			var config = new AppSettings();

			Configuration.Bind(config);

			services.AddHttpContextAccessor();
			services.AddSingleton(config);
			services.AddJwt(config);
			services.AddApplicationUser();
			services.AddUseCases();
			services.AddTransient<UseCaseHandler>();
			services.AddTransient<IUseCaseLogger, DatabaseExceptionLogger>();
			services.AddDbContext<DoloresContext>();
			//services.AddTransient<DbContextOptions>(x =>
			//{
			//	var optionsBuilder = new DbContextOptionsBuilder();

			//	var conString = x.GetService<AppSettings>().ConnString;

			//	optionsBuilder.UseSqlServer(conString).UseLazyLoadingProxies();

			//	return optionsBuilder.Options;
			//});

			//services.AddTransient(x =>
			//{
			//	var optionsBuilder = new DbContextOptionsBuilder();

			//	var conString = x.GetService<AppSettings>().ConnString;

			//	optionsBuilder.UseSqlServer(conString).UseLazyLoadingProxies();

			//	var options = optionsBuilder.Options;

			//	return new DoloresContext(options);
			//});

			services.AddControllers();
			services.AddSwaggerGen();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
				app.UseSwagger();
				app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Dolores.Api v1"));
			}

			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseRouting();
			app.UseMiddleware<GlobalExceptionHandler>();
			app.UseAuthentication();
			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}
