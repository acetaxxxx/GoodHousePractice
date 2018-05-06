using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;

namespace WebApplication_Practice.ViewModels.Customer
{
	[BindNever]
	public class CustomerGridViewModel
	{
		public string CustomerTitle { get; set; }
		public string CustomerName { get; set; }
		public string CompanyName { get; set; }
		public string City { get; set; }
		public string Country { get; set; }
		public string PhoneNumber { get; set; }
	}
}