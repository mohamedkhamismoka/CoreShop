using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebApplication12.BL.Interfaces;
using WebApplication12.BL.VM;
using WebApplication12.DAL.Entity;

namespace WebApplication12.Controllers
{
    public class CustomerController : Controller
    {  // private to be hidden
        //readonly to assign in constructor to achieve DI
        private readonly IMapper map;
        private readonly ICustomer Custom;
        public CustomerController(IMapper map, ICustomer Custom)
        {
            this.map = map;
            this.Custom = Custom;
        }

        public IActionResult Index()
        {
            var data = Custom.Get();
            var res = map.Map<IEnumerable<CustomerVM>>(data);
            return View(res);


        }

        public IActionResult Details(int id)
        {
            var data = Custom.GetById(id);
            var res = map.Map<CustomerVM>(data);
            return View(res);


        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CustomerVM customer)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = Custom.Get();
                    var x = false;
                    var y = false;
                    foreach (var item in data)

                    {
                        //check if mail or phone exist before to achieve uniguness
                        if (item.mail == customer.mail)
                        {
                            ViewBag.mailwarn = "Already Existed Mail";
                            x = true;
                        }
                        if (item.phone == customer.phone)
                        {
                            ViewBag.phonewarn = "Already Existed phone";
                            y = true;
                        }

                    }
                    if (x == true || y == true)
                    {
                        return View(customer);
                    }
                    else
                    {
                        var res = map.Map<Customer>(customer);
                        Custom.add(res);
                        return RedirectToAction("Index");
                    }


                }
                return View(customer);
            }
            catch (Exception ex)
            {
                return View(customer);
            }

        }
        public IActionResult Update(int id)
        {
            var data = Custom.GetById(id);
            var result = map.Map<CustomerVM>(data);
            return View(result);

        }

        [HttpPost]
        public IActionResult Update(CustomerVM cust, string eemail, string pphone)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = Custom.Get();
                    var x = false;
                    var y = false;
                    foreach (var item in data)
                    { //check if mail or phone exist before to achieve uniguness
                        if (item.mail == cust.mail && eemail != item.mail)
                        {
                            ViewBag.mailwarn = "Already Existed Mail";
                            x = true;
                        }
                        if (item.phone == cust.phone && item.phone != pphone)
                        {
                            ViewBag.phonewarn = "Already Existed phone";
                            y = true;
                        }

                    }
                    if (x == true || y == true)
                    {
                        return View(cust);
                    }
                    else
                    {
                        var res = map.Map<Customer>(cust);
                        Custom.update(cust.Custo_Id, res);
                        return RedirectToAction("Index");
                    }

                }

                return View(cust);
            }
            catch (Exception ex)
            {
                return View(cust);
            }
        }

        public IActionResult Delete(int id)
        {
            var data = Custom.GetById(id);
            var result = map.Map<CustomerVM>(data);
            return View(result);
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult ConfirmDelete(int id)
        {
            Custom.remove(id);
            return RedirectToAction("Index");
        }
    }
}
