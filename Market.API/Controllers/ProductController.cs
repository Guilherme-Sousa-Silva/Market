using Market.API.Data;
using Market.API.Models;
using Market.API.ViewModels.Products;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Market.API.Controllers
{
	[ApiController]
	[Route("product")]
	public class ProductController : ControllerBase
	{
		[HttpGet]
		public async Task<IActionResult> Get([FromServices] Context context)
		{
			var product = await context.Products.ToListAsync();
			return Ok(product);
		}

		[HttpGet]
		[Route("get/{id:Guid}")]
		public async Task<IActionResult> GetById(
			[FromRoute] Guid id,
			[FromServices] Context context)
		{
			var product = await context.Products.FirstOrDefaultAsync(x => x.Id == id);

			if (product == null)
				NotFound($"Não foi possível encontrar o produto com o id {id}");

			return Ok(product);
		}

		[HttpPost]
		[Route("create")]
		public async Task<IActionResult> Create(
			[FromBody] CreateProductViewModel product,
			[FromServices] Context context)
		{
			var newProduct = new Product(
				product.Name,
				product.Price);

			await context.Products.AddAsync(newProduct);
			await context.SaveChangesAsync();

			return Created($"get/{newProduct.Id}", newProduct);
		}

		[HttpPut]
		[Route("edit/{id:Guid}")]
		public async Task<IActionResult> Edit(
			[FromRoute] Guid id,
			[FromBody] EditProductViewModel product,
			[FromServices] Context context)
		{
			var productToUpdate = await context.Products.FirstOrDefaultAsync(x => x.Id == id);
			if (productToUpdate == null)
				return NotFound("Produto não encontrado!");

			productToUpdate.EditName(product.Name);
			productToUpdate.EditPrice(product.Price);
			
			context.Products.Update(productToUpdate);
			await context.SaveChangesAsync();

			return Ok($"Produto editado com sucesso!");
		}

		[HttpDelete]
		[Route("delete/{id:Guid}")]
		public async Task<IActionResult> Delete(
			[FromRoute] Guid id,
			[FromServices] Context context)
		{
			var productToUpdate = await context.Products.FirstOrDefaultAsync(x => x.Id == id);
			if (productToUpdate == null)
				return NotFound("Produto não encontrado!");

			context.Products.Remove(productToUpdate);
			await context.SaveChangesAsync();

			return Ok($"Produto deletado com sucesso!");
		}
	}
}
