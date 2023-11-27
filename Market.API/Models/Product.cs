using Microsoft.IdentityModel.Tokens;

namespace Market.API.Models
{
	public class Product
	{
		public Product(string name, string price)
		{
			Id = Guid.NewGuid();
			Name = name;
			Price = price;
			Created = DateTime.UtcNow;
			Modified = null;
		}

		public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Price { get; private set; }
        public DateTime Created { get; private set; }
        public DateTime? Modified { get; private set; }

		public void EditName(string name) 
		{
			if (string.IsNullOrEmpty(name))
				return;

			Name = name;
			Modified = DateTime.UtcNow;
		}

		public void EditPrice(string price)
		{
			if (string.IsNullOrEmpty(price))
				return;

			Price = price;
			Modified = DateTime.UtcNow;
		}
	}

}
