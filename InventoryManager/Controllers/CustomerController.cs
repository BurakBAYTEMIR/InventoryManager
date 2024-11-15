using FluentValidation.Results;
using InventoryManager.Business.Concrete;
using InventoryManager.Business.ValidationRules.FluentValidation;
using InventoryManager.DataAccess.EntityFramework;
using InventoryManager.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace InventoryManager.UI.Controllers
{
    public class CustomerController : Controller
    {
        private CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
        JobManager jobManager = new JobManager(new EfJobDal());
        public IActionResult Index()
        {
            var values = customerManager.TGetCustomerListWithJob();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddCustomer()
        {
            List<SelectListItem> values = (from x in jobManager.TGetList()
                                           select new SelectListItem
                                           {
                                               Text = x.JobName,
                                               Value = x.JobId.ToString()
                                           }).ToList();
            ViewBag.v = values;
            return View();
        }
        [HttpPost]
        public IActionResult AddCustomer(Customer customer)
        {
            CustomerValidator validationRules = new CustomerValidator();
            ValidationResult result = validationRules.Validate(customer);

            if (result.IsValid)
            {
                customerManager.TInsert(customer);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        public IActionResult DeleteCustomer(int id)
        {
            var value = customerManager.TGetById(id);
            customerManager.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateCustomer(int id)
        {
            List<SelectListItem> values = (from x in jobManager.TGetList()
                                           select new SelectListItem
                                           {
                                               Text = x.JobName,
                                               Value = x.JobId.ToString()
                                           }).ToList();
            ViewBag.v = values;
            var value = customerManager.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateCustomer(Customer customer)
        {
            customerManager.TUpdate(customer);
            return RedirectToAction("Index");
        }

    }
}
