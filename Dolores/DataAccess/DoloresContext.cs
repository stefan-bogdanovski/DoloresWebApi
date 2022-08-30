namespace DataAccess
{
	using System;
	using System.Collections.Generic;
	using System.IO;
	using System.Linq;
	using Domain;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.Extensions.Configuration;

	public class DoloresContext : DbContext
	{
		public DbSet<Perfume> Perfumes { get; set; }
		public DbSet<Size> Sizes { get; set; }
		public DbSet<Brand> Brands { get; set; }
		public DbSet<MoneyCurrency> MoneyCurrencies { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<Orderline> Orderlines { get; set; }
		public DbSet<PaymentMethod> PaymentMethods { get; set; }
		public DbSet<PerfumeSizes> PerfumeSizes { get; set; }
		public DbSet<Pricelist> Pricelists { get; set; }
		public DbSet<Role> Roles { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<UserUseCase> UserUseCases { get; set; }
		public DbSet<MeasurementUnit> MeasurementUnits { get; set; }
		public DbSet<Log> Logs { get; set; }

		public IApplicationUser User { get; }

		public DoloresContext()
		{

		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-BQQNN13\SQLEXPRESS;Initial Catalog=Dolores;Integrated Security=True");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
			modelBuilder.Entity<User>()
				.HasData(new Domain.User
				{
					Id = 10,
					FirstName = "Marko",
					LastName = "Markovic",
					Email = "marko123@gmail.com",
					Username = "markeza",
					Password = "marko123",
					IsActive = true,
					RoleId = 1
				});
			modelBuilder.Entity<Role>()
				.HasData(new List<Role>
				{
					new Role
					{
						Id = 1,
						Name = "Administrator",
					},
					new Role
					{
						Id = 2,
						Name = "Authorized"
					},
				});
			modelBuilder.Entity<Brand>()
				.HasData(new List<Brand>
				{
					new Brand
					{
						Id = 1,
						Name = "Armani",
					},
					new Brand
					{
						Id = 2,
						Name = "Gucci"
					},
					new Brand
					{
						Id = 3,
						Name = "Creed"
					},
					new Brand
					{
						Id = 4,
						Name = "Dior"
					},
					new Brand
					{
						Id = 5,
						Name = "Versace"
					},
					new Brand
					{
						Id = 6,
						Name = "Tom Ford"
					},
					new Brand
					{
						Id = 7,
						Name = "Dolce&Gabbana"
					},				
				});
			modelBuilder.Entity<Perfume>()
				.HasData(new List<Perfume>
				{
					new Perfume
					{
						Id = 1,
						Name = "Tobacco Vanille",
						BrandId = 6
					},
					new Perfume
					{
						Id = 2,
						Name = "Soleil Neige",
						BrandId = 6
					},
					new Perfume
					{
						Id = 3,
						Name = "Noir Extreme",
						BrandId = 6
					},
					new Perfume
					{
						Id = 4,
						Name = "Light Blue Pour Homme",
						BrandId = 7
					},
					new Perfume
					{
						Id = 5,
						Name = "The one",
						BrandId = 7
					},
					new Perfume
					{	Id = 6,
						Name = "Beauty Dolce Garden",
						BrandId = 7
					},
					new Perfume
					{	Id = 7,
						Name = "K by Dolce&Gabbana",
						BrandId = 7
					},
					new Perfume
					{	Id = 8,
						Name = "Bright Crystal",
						BrandId = 5
					},
					new Perfume
					{	Id = 9,
						Name = "Eros",
						BrandId = 5
					},
					new Perfume
					{	Id = 10,
						Name = "Crystal Noir",
						BrandId = 5
					},
					new Perfume
					{	Id = 11,
						Name = "Miss Dior Blooming Bouquet",
						BrandId = 4
					},
					new Perfume
					{	Id = 12,
						Name = "Sauvage",
						BrandId = 4
					},
					new Perfume
					{	Id = 13,
						Name = "J'adore",
						BrandId = 4
					},
					new Perfume
					{	Id = 14,
						Name = "Homme",
						BrandId = 4
					},
					new Perfume
					{	Id = 15,
						Name = "Aventus",
						BrandId = 3
					},
					new Perfume
					{	Id = 16,
						Name = "Love In White",
						BrandId = 3
					},
					new Perfume
					{	Id = 17,
						Name = "Viking",
						BrandId = 3
					},
					new Perfume
					{	Id = 18,
						Name = "Royal Princess Oud",
						BrandId = 3
					},
					new Perfume
					{	Id = 19,
						Name = "Virgin Island Water",
						BrandId = 3
					},
					new Perfume
					{	Id = 20,
						Name = "Love In Black",
						BrandId = 3
					},
					new Perfume
					{	Id = 21,
						Name = "Guilty",
						BrandId = 2
					},
					new Perfume
					{	Id = 22,
						Name = "Bloom",
						BrandId = 2
					},
					new Perfume
					{	Id = 23,
						Name = "Tears From The Moon",
						BrandId = 2
					},
					new Perfume
					{	Id = 24,
						Name = "My Way",
						BrandId = 1
					},
					new Perfume
					{	Id = 25,
						Name = "Armani Prive Bleu Lazuli",
						BrandId = 1
					},
					new Perfume
					{	Id = 26,
						Name = "Armani Code",
						BrandId = 1
					}
				});
			modelBuilder.Entity<MeasurementUnit>()
				.HasData(new List<MeasurementUnit>
				{
					new MeasurementUnit
					{
						Id = 1,
						Unit = "ml"
					},
					new MeasurementUnit
					{
						Id = 2,
						Unit = "dl"
					},
					new MeasurementUnit
					{
						Id = 3,
						Unit = "cl"
					},
					new MeasurementUnit
					{
						Id = 4,
						Unit = "oz."
					}
				});
			modelBuilder.Entity<Size>()
				.HasData(new List<Size>
				{
					new Size
					{
						Id = 1,
						PerfumeSize = 30,
						MeasurementUnitId = 1
					},
					new Size
					{
						Id = 2,
						PerfumeSize = 50,
						MeasurementUnitId = 1
					},
					new Size
					{
						Id = 3,
						PerfumeSize = 100,
						MeasurementUnitId = 1
					},
					new Size
					{
						Id = 4,
						PerfumeSize = 1.7,
						MeasurementUnitId = 4
					},
					new Size
					{
						Id = 5,
						PerfumeSize = 3.38,
						MeasurementUnitId = 4
					}
				});
			modelBuilder.Entity<PerfumeSizes>()
				.HasData(new List<PerfumeSizes>
				{
					new PerfumeSizes
					{
						Id = 1,
						PerfumeId = 1,
						Quantity = 10,
						SizeId = 1,
					},
					new PerfumeSizes
					{
						Id = 2,
						PerfumeId = 1,
						Quantity = 5,
						SizeId = 2
					},
					new PerfumeSizes
					{
						Id = 3,
						PerfumeId = 1,
						Quantity = 3,
						SizeId = 3
					},
					new PerfumeSizes
					{
						Id = 4,
						PerfumeId = 2,
						Quantity = 7,
						SizeId = 1
					},
					new PerfumeSizes
					{
						Id = 5,
						PerfumeId = 2,
						Quantity = 2,
						SizeId = 2
					},
					new PerfumeSizes
					{
						Id = 6,
						PerfumeId = 2,
						Quantity = 5,
						SizeId = 3
					},
					new PerfumeSizes
					{
						Id = 7,
						PerfumeId = 3,
						Quantity = 7,
						SizeId = 1
					},
					new PerfumeSizes
					{
						Id = 8,
						PerfumeId = 3,
						Quantity = 2,
						SizeId = 3
					},
					new PerfumeSizes
					{
						Id = 9,
						PerfumeId = 3,
						Quantity = 5,
						SizeId = 2
					},
					new PerfumeSizes
					{
						Id = 10,
						PerfumeId = 4,
						Quantity = 7,
						SizeId = 3
					},
					new PerfumeSizes
					{
						Id = 11,
						PerfumeId = 4,
						Quantity = 2,
						SizeId = 1
					},
					new PerfumeSizes
					{
						Id = 12,
						PerfumeId = 4,
						Quantity = 5,
						SizeId = 2
					},
					new PerfumeSizes
					{
						Id = 13,
						PerfumeId = 5,
						Quantity = 7,
						SizeId = 3
					},
					new PerfumeSizes
					{
						Id = 14,
						PerfumeId = 5,
						Quantity = 2,
						SizeId = 1
					},
					new PerfumeSizes
					{
						Id = 15,
						PerfumeId = 5,
						Quantity = 5,
						SizeId = 2
					},
					new PerfumeSizes
					{
						Id = 16,
						PerfumeId = 6,
						Quantity = 7,
						SizeId = 3
					},
					new PerfumeSizes
					{
						Id = 17,
						PerfumeId = 6,
						Quantity = 2,
						SizeId = 1
					},
					new PerfumeSizes
					{
						Id = 18,
						PerfumeId = 6,
						Quantity = 5,
						SizeId = 2
					},
					new PerfumeSizes
					{
						Id = 19,
						PerfumeId = 7,
						Quantity = 7,
						SizeId = 3
					},
					new PerfumeSizes
					{
						Id = 20,
						PerfumeId = 7,
						Quantity = 2,
						SizeId = 1
					},
					new PerfumeSizes
					{
						Id = 21,
						PerfumeId = 7,
						Quantity = 5,
						SizeId = 2
					},
					new PerfumeSizes
					{
						Id = 22,
						PerfumeId = 8,
						Quantity = 7,
						SizeId = 3
					},
					new PerfumeSizes
					{
						Id = 23,
						PerfumeId = 8,
						Quantity = 2,
						SizeId = 1
					},
					new PerfumeSizes
					{
						Id = 24,
						PerfumeId = 8,
						Quantity = 5,
						SizeId = 2
					},
					new PerfumeSizes
					{
						Id = 25,
						PerfumeId = 9,
						Quantity = 0,
						SizeId = 3
					},
					new PerfumeSizes
					{
						Id = 26,
						PerfumeId = 9,
						Quantity = 2,
						SizeId = 1
					},
					new PerfumeSizes
					{
						Id = 27,
						PerfumeId = 9,
						Quantity = 5,
						SizeId = 2
					},
					new PerfumeSizes
					{
						Id = 28,
						PerfumeId = 10,
						Quantity = 0,
						SizeId = 2
					},
					new PerfumeSizes
					{
						Id = 29,
						PerfumeId = 10,
						Quantity = 2,
						SizeId = 3
					},
					new PerfumeSizes
					{
						Id = 30,
						PerfumeId = 10,
						Quantity = 5,
						SizeId = 1
					},
					new PerfumeSizes
					{
						Id = 31,
						PerfumeId = 11,
						Quantity = 0,
						SizeId = 2
					},
					new PerfumeSizes
					{
						Id = 32,
						PerfumeId = 11,
						Quantity = 2,
						SizeId = 3
					},
					new PerfumeSizes
					{
						Id = 33,
						PerfumeId = 11,
						Quantity = 5,
						SizeId = 1
					},
					new PerfumeSizes
					{
						Id = 34,
						PerfumeId = 12,
						Quantity = 15,
						SizeId = 2
					},
					new PerfumeSizes
					{
						Id = 35,
						PerfumeId = 12,
						Quantity = 2,
						SizeId = 3
					},
					new PerfumeSizes
					{
						Id = 36,
						PerfumeId = 12,
						Quantity = 5,
						SizeId = 1
					},
					new PerfumeSizes
					{	Id = 37,
						PerfumeId = 13,
						Quantity = 1,
						SizeId = 2
					},
					new PerfumeSizes
					{	Id = 38,
						PerfumeId = 13,
						Quantity = 2,
						SizeId = 3
					},
					new PerfumeSizes
					{	Id = 39,
						PerfumeId = 13,
						Quantity = 5,
						SizeId = 1
					},
					new PerfumeSizes
					{	Id = 40,
						PerfumeId = 14,
						Quantity = 4,
						SizeId = 2
					},
					new PerfumeSizes
					{	Id = 41,
						PerfumeId = 14,
						Quantity = 2,
						SizeId = 3
					},
					new PerfumeSizes
					{	Id = 42,
						PerfumeId = 14,
						Quantity = 5,
						SizeId = 1
					},
					new PerfumeSizes
					{	Id = 43,
						PerfumeId = 15,
						Quantity = 4,
						SizeId = 2
					},
					new PerfumeSizes
					{	Id = 44,
						PerfumeId = 15,
						Quantity = 20,
						SizeId = 3
					},
					new PerfumeSizes
					{	Id = 45,
						PerfumeId = 15,
						Quantity = 5,
						SizeId = 1
					},
					new PerfumeSizes
					{	Id = 46,
						PerfumeId = 16,
						Quantity = 4,
						SizeId = 2
					},
					new PerfumeSizes
					{	Id = 47,
						PerfumeId = 16,
						Quantity = 2,
						SizeId = 3
					},
					new PerfumeSizes
					{	Id = 48,
						PerfumeId = 16,
						Quantity = 5,
						SizeId = 1
					},
					new PerfumeSizes
					{	Id = 49,
						PerfumeId = 17,
						Quantity = 1,
						SizeId = 2
					},
					new PerfumeSizes
					{	Id = 50,
						PerfumeId = 17,
						Quantity = 1,
						SizeId = 3
					},
					new PerfumeSizes
					{	Id = 51,
						PerfumeId = 17,
						Quantity = 2,
						SizeId = 1
					},
					new PerfumeSizes
					{	Id = 52,
						PerfumeId = 18,
						Quantity = 1,
						SizeId = 2
					},
					new PerfumeSizes
					{	Id = 53,
						PerfumeId = 18,
						Quantity = 1,
						SizeId = 3
					},
					new PerfumeSizes
					{	Id = 54,
						PerfumeId = 18,
						Quantity = 2,
						SizeId = 1
					},
					new PerfumeSizes
					{	Id = 55,
						PerfumeId = 19,
						Quantity = 1,
						SizeId = 3
					},
					new PerfumeSizes
					{	Id = 56,
						PerfumeId = 19,
						Quantity = 1,
						SizeId = 2
					},
					new PerfumeSizes
					{	Id = 57,
						PerfumeId = 19,
						Quantity = 2,
						SizeId = 1
					},
					new PerfumeSizes
					{	Id = 58,
						PerfumeId = 20,
						Quantity = 1,
						SizeId = 3
					},
					new PerfumeSizes
					{	Id = 59,
						PerfumeId = 20,
						Quantity = 1,
						SizeId = 2
					},
					new PerfumeSizes
					{	Id = 60,
						PerfumeId = 20,
						Quantity = 2,
						SizeId = 1
					},
					new PerfumeSizes
					{	Id = 61,
						PerfumeId = 21,
						Quantity = 11,
						SizeId = 3
					},
					new PerfumeSizes
					{	Id = 62,
						PerfumeId = 21,
						Quantity = 3,
						SizeId = 2
					},
					new PerfumeSizes
					{	Id = 63,
						PerfumeId = 21,
						Quantity = 7,
						SizeId = 1
					},
					new PerfumeSizes
					{	Id = 64,
						PerfumeId = 22,
						Quantity = 7,
						SizeId = 3
					},
					new PerfumeSizes
					{	Id = 65,
						PerfumeId = 22,
						Quantity = 3,
						SizeId = 2
					},
					new PerfumeSizes
					{	Id = 66,
						PerfumeId = 22,
						Quantity = 7,
						SizeId = 1
					},
					new PerfumeSizes
					{	Id = 67,
						PerfumeId = 23,
						Quantity = 7,
						SizeId = 3
					},
					new PerfumeSizes
					{	Id = 68,
						PerfumeId = 23,
						Quantity = 3,
						SizeId = 2
					},
					new PerfumeSizes
					{	Id = 69,
						PerfumeId = 23,
						Quantity = 7,
						SizeId = 1
					},
					new PerfumeSizes
					{	Id = 70,
						PerfumeId = 24,
						Quantity = 7,
						SizeId = 3
					},
					new PerfumeSizes
					{	Id = 71,
						PerfumeId = 24,
						Quantity = 5,
						SizeId = 2
					},
					new PerfumeSizes
					{	Id = 72,
						PerfumeId = 24,
						Quantity = 7,
						SizeId = 1
					},
					new PerfumeSizes
					{	Id = 73,
						PerfumeId = 25,
						Quantity = 25,
						SizeId = 3
					},
					new PerfumeSizes
					{	Id = 74,
						PerfumeId = 25,
						Quantity = 11,
						SizeId = 2
					},
					new PerfumeSizes
					{	Id = 75,
						PerfumeId = 25,
						Quantity = 14,
						SizeId = 1
					},
					new PerfumeSizes
					{	Id = 76,
						PerfumeId = 26,
						Quantity = 25,
						SizeId = 3
					},
					new PerfumeSizes
					{	Id = 77,
						PerfumeId = 26,
						Quantity = 11,
						SizeId = 2
					},
					new PerfumeSizes
					{	Id = 78,
						PerfumeId = 26,
						Quantity = 14,
						SizeId = 1
					}
				});
			modelBuilder.Entity<MoneyCurrency>()
				.HasData(new List<MoneyCurrency>
				{
					new MoneyCurrency
					{
						Id = 1,
						Currency = "€"
					},
					new MoneyCurrency
					{
						Id = 2,
						Currency = "$"
					}
				});
			modelBuilder.Entity<Orderline>()
				.HasData(new List<Orderline>
				{
					new Orderline
					{
						Id = 5,
						PricelistId = 3,
						UserId = 1,
						Quantity = 5,
						IsActive = true,
						OrderId = 1
					},
					new Orderline
					{
						Id = 6,
						PricelistId = 2,
						UserId = 1,
						Quantity = 1,
						IsActive = true,
						OrderId = 1
					},
					new Orderline
					{
						Id = 7,
						PricelistId = 2,
						UserId = 2,
						Quantity = 3,
						IsActive = true,
						OrderId = 2
					}
				});
			modelBuilder.Entity<PaymentMethod>()
				.HasData(new List<PaymentMethod>
				{
					new PaymentMethod
					{
						Id = 1,
						Method = "Online"
					},
					new PaymentMethod
					{
						Id = 2,
						Method = "OnDeliveryToCourier"
					}
				});
			modelBuilder.Entity<Order>()
				.HasData(new List<Order>()
				{
					new Order()
					{
						Id = 1,
						PaymentMethodId = 1,
						Address = "Jovana Cvijica 2",
						CardType = "MasterCard",
						CreditCardNumber = "0000-0000-0000-0000",
						CVV = "173",
						Date = DateTime.UtcNow,
					},
					new Order()
					{
						Id = 2,
						PaymentMethodId = 2,
						Address = "Jovana Cvijica 2",
						Date = DateTime.UtcNow,
					}
				});

			//var pricelists = new List<Pricelist>();
			//Random rand = new Random();
			//for(int i = 1; i < 79; i++)
			//{
			//	pricelists.Add(new Pricelist
			//	{
			//		Id = i,
			//		PerfumeSizeId = i,
			//		Date = DateTime.UtcNow,
			//		CurrencyId = 1,
			//		DiscountInPercent = rand.Next(0, 10),
			//		Price = (decimal)Math.Round((rand.Next(100, 200) * (rand.NextDouble() + 0.5)), 2)
			//	});
			//}
			//modelBuilder.Entity<Pricelist>()
			//	.HasData(pricelists);

			base.OnModelCreating(modelBuilder);
		}

		public override int SaveChanges()
		{
			foreach (var entry in this.ChangeTracker.Entries())
			{
				if (entry.Entity is Entity e)
				{
					switch (entry.State)
					{
						case EntityState.Added:
							e.IsActive = true;
							e.CreatedAt = DateTime.UtcNow;
							break;
						case EntityState.Modified:
							e.UpdatedAt = DateTime.UtcNow;
							e.UpdatedBy = User?.Identity;
							break;
					}
				}
			}

			return base.SaveChanges();
		}
	}
}
