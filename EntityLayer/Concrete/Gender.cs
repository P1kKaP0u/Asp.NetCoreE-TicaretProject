using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Gender
	{
		[Key]
		public int Id { get; set; }
		public string GenderType { get; set; }
		public Product Product { get; set; }
	}
}
