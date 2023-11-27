using Market.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Market.API.Data.Mappings
{
	public class ProductMap : IEntityTypeConfiguration<Product>
	{
		public void Configure(EntityTypeBuilder<Product> builder)
		{
			// tabela
			builder.ToTable("Product");

			// chave primaria
			builder.HasKey(x => x.Id);

			// Colunas
			builder.Property(x => x.Name)
				.IsRequired()
				.HasColumnName("Name")
				.HasColumnType("NVARCHAR")
				.HasMaxLength(50);

			builder.Property(x => x.Price)
				.IsRequired()
				.HasColumnName("Price")
				.HasColumnType("NVARCHAR")
				.HasMaxLength(15);

			builder.Property(x => x.Created)
				.IsRequired()
				.HasColumnName("Created")
				.HasColumnType("SMALLDATETIME");

			builder.Property(x => x.Modified)
				.HasColumnName("Modified")
				.HasColumnType("SMALLDATETIME");
		}
	}
}
