using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication_Practice.ViewModels.Customer;
using WebApplication_Practice.Models;

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
            return PartialView("_Grid", list);
        }

        public ActionResult Detail()
        {
            var moodel = new CustomerViewModel()
            {
                Address = "第一線是",
                CompanyName = "第一家銀行",
                City = "新北市",
                ContactName = "王大明",
                ContactTitle = "Vice President",
                Country = "中東",
                CustomerID = "None",
                Fax = "+55 123456789",
                Phone = "+65 123456789",
                PostalCode = "545"
            };
            return View();
        }
    }
}