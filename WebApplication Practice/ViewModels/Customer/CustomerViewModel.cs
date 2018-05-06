using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Services.Description;

namespace WebApplication_Practice.ViewModels.Customer
{
	public class CustomerViewModel
	{
		[DisplayName("聯絡人ID")]
		[Required]
		public string CustomerID { get; set; }

		[DisplayName("公司名稱")]
		[Required]
		public string CompanyName { get; set; }

		[DisplayName("聯絡人姓名")]
		[Required]
		public string ContactName { get; set; }

		[DisplayName("聯絡人職稱")]
		[Required]
		public string ContactTitle { get; set; }

		[DisplayName("公司地址")]
		[Required]
		public string Address { get; set; }

		[DisplayName("城市")]
		public string City { get; set; }

		[DisplayName("行政區")]
		public string Region { get; set; }

		[DisplayName("郵遞區號")]
		public string PostalCode { get; set; }

		[DisplayName("國家")]
		public string Country { get; set; }

		[DisplayName("連絡電話")]
		[Required]
		public string Phone { get; set; }

		[DisplayName("傳真")]
		[Required]
		public string Fax { get; set; }
	}
}