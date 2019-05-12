using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VHSOnly.Models;
using VHSOnly.ViewModels;

namespace VHSOnly.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
           {
               new Customer{Name = "Whitney Houston", Id = 1},
               new Customer{Name = "Markie Mark", Id = 2},
               new Customer{Name = "Prince", Id = 3},
           };
        }

        // GET: Customers
        public ActionResult Index()
        {
            //var movieViewModel = new CustomersViewModel
            //{
            //    Customers = _context.Customers
            //};

            var customers = _context.Customers;
            return View(customers);
        }

        [Route("Customers/Details/{id}")]
        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();



            return View(customer);
        }
    }
}