namespace Dolores.Extensions
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using Application.UseCases.Commands;
	using Application.UseCases.Queries;
	using DataAccess;
	using Dolores.Authentication;
	using Dolores.Authentication.Users;
	using Dolores.Config;
	using Domain;
	using Implementation.UseCases.Commands;
	using Implementation.UseCases.Queries;
	using Implementation.UseCases.Validations;
	using Implementation.UseCases.Validators;
	using Microsoft.AspNetCore.Authentication.JwtBearer;
	using Microsoft.AspNetCore.Http;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Design;
	using Microsoft.Extensions.Configuration;
	using Microsoft.Extensions.DependencyInjection;
	using Microsoft.IdentityModel.Tokens;
	using Newtonsoft.Json;

	public static class ServicesExtensions
	{
		public static void AddJwt(this IServiceCollection services, AppSettings settings)
		{
			services.AddTransient(x =>
			{
				var context = x.GetService<DoloresContext>();
				var settings = x.GetService<AppSettings>();

				return new JwtTokenManager(context, settings.JwtSettings);
			});


			services.AddAuthentication(options =>
			{
				options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
				options.DefaultSignInScheme = JwtBearerDefaults.AuthenticationScheme;
				options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
			}).AddJwtBearer(cfg =>
			{
				cfg.RequireHttpsMetadata = false;
				cfg.SaveToken = true;
				cfg.TokenValidationParameters = new TokenValidationParameters
				{
					ValidIssuer = settings.JwtSettings.Issuer,
					ValidateIssuer = true,
					ValidAudience = "Any",
					ValidateAudience = true,
					IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(settings.JwtSettings.SecretKey)),
					ValidateIssuerSigningKey = true,
					ValidateLifetime = true,
					ClockSkew = TimeSpan.Zero
				};
			});
		}

		public static void AddUseCases(this IServiceCollection services)
		{
			services.AddTransient<IRegisterUserCommand, EFRegisterUserCommand>();
			services.AddTransient<IGetUsersQuery, EFGetUsersQuery>();
			services.AddTransient<IGetUserQuery, EFGetUserQuery>();
			services.AddTransient<IGetBrandsQuery, EFGetBrandsQuery>();
			services.AddTransient<IGetBrandQuery, EFGetBrandQuery>();
			services.AddTransient<ICreateBrandCommand, EFCreateBrandCommand>();
			services.AddTransient<IDeleteBrandCommand, EFDeleteBrandCommand>();
			services.AddTransient<IGetPerfumesQuery, EFGetPerfumesQuery>();
			services.AddTransient<IGetPerfumeQuery, EFGetPerfumeQuery>();
			services.AddTransient<ICreatePerfumeCommand, EFCreatePerfumeCommand>();
			services.AddTransient<IDeletePerfumeCommand, EFDeletePerfumeCommand>();
			services.AddTransient<IGetOrderlinesQuery, EFGetOrderlinesQuery>();
			services.AddTransient<ICreateOrderlineCommand, EFCreateOrderlineCommand>();
			services.AddTransient<IDeleteOrderlineCommand, EFDeleteOrderlineCommand>();
			services.AddTransient<IGetLogsQuery, EFGetLogsQuery>();
			services.AddTransient<IGetOrdersQuery, EFGetOrdersQuery>();
			services.AddTransient<ICreateOrderCommand, EFCreateOrderCommand>();

			#region Validators
			services.AddTransient<CreateUserValidator>();
			services.AddTransient<CreateBrandValidator>();
			services.AddTransient<CreatePerfumeValidator>();
			services.AddTransient<CreateOrderlineValidator>();
			services.AddTransient<CreateOrderValidator>();
			#endregion
		}

		public static void AddApplicationUser(this IServiceCollection services)
		{
			services.AddTransient<IApplicationUser>(x =>
			{
				var accessor = x.GetService<IHttpContextAccessor>();
				var header = accessor.HttpContext.Request.Headers["Authorization"];

				//Pristup payload-u
				var claims = accessor.HttpContext.User;

				if (claims == null || claims.FindFirst("UserId") == null)
				{
					return new AnonymousUser();
				}

				var actor = new JwtTokenAuthenticatedUser
				{
					Email = claims.FindFirst("Email").Value,
					Id = Int32.Parse(claims.FindFirst("UserId").Value),
					Identity = claims.FindFirst("Email").Value,
					UseCaseIds = JsonConvert.DeserializeObject<List<int>>(claims.FindFirst("UseCases").Value)
				};

				return actor;
			});
		}

		//public static void AddDoloresContext(this IServiceCollection services)
		//{
		//	services.AddTransient(x =>
		//	{
		//		var optionsBuilder = new DbContextOptionsBuilder<DoloresContext>();

		//		var conString = x.GetService<AppSettings>()?.ConnString;
		//		optionsBuilder.UseSqlServer(conString).UseLazyLoadingProxies();
		//		Console.WriteLine(conString);
		//		var options = optionsBuilder.Options;
		//		return new DoloresContext(options);
		//	});
		//}
	}
}
