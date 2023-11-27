using Market.API.Data.Mappings;
using Market.API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Market.API.Data
{
	public class Context : DbContext
	{
		public Context(DbContextOptions<Context> options) 
			: base(options)
		{
		}

		public DbSet<Product> Products { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
			=> optionsBuilder.UseSqlServer("Server=localhost,1433;Database=Market;User ID=sa;Password=1q2w3e4r@#$; TrustServerCertificate=True");

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new ProductMap());
		}
	}
}
