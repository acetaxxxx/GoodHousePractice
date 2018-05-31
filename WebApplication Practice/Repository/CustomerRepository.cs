using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication_Practice.Models;

namespace WebApplication_Practice.Repository
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            var customers = new NorthwindEntities().Customers;
        }
    }
}