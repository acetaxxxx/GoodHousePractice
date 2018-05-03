using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication_Practice.ViewModels.Customer;

namespace WebApplication_Practice.Controllers
{
	public class CustomerController : Controller
	{
		/// <summary>
		/// Customer首頁
		/// </summary>
		/// <returns></returns>
		public ActionResult Index()
		{
			return View("Customer");
		}

		/// <summary>
		/// 查詢
		/// </summary>
		/// <returns></returns>
		public ActionResult QueryGrid()
		{
			var list = new List<CustomerGridViewModel>()
			{
				new CustomerGridViewModel()
				{
					CompanyName = "First Company",
					City = "Taipei",
					Country = "Taipei",
					CustomerName = "Stark Shark",
					CustomerTitle = "Vice President",
					PhoneNumber = "0123456789"
				},
				new CustomerGridViewModel()
				{
					CompanyName = "Second Company",
					City = "Hsinchu",
					Country = "Taipei",
					CustomerName = "Stark Shark",
					CustomerTitle = " President",
					PhoneNumber = "+886 351234567"
				},
			};
			return PartialView("_Grid" , list);
		}
	}
}