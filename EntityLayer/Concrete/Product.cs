using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Product
	{
		[Key]
		public int Id { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public int Stock { get; set; }
		public bool Popular { get; set; }
		public bool IsApproved { get; set; }
		public string Image { get; set; }
		public int Quantity { get; set; }
		public int CategoryId { get; set; }
		public Category Category { get; set; }
		public List<Gender> Genders { get; set; }
		public List<Colour> Colours { get; set; }
	}
}
