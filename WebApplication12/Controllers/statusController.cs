﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebApplication12.BL.Interfaces;
using WebApplication12.BL.VM;
using WebApplication12.DAL.Database;

namespace WebApplication12.Controllers
{
    public class statusController : Controller
    {  // private to be hidden
        //readonly to assign in constructor to achieve DI
        private readonly Data d;
        private readonly ICustomer cust;
        private readonly IMapper map;
        private readonly IProduct prd;
        private readonly IOrder ord;
        private readonly IProduct_order pro_ord;
        public statusController(ICustomer cust, IMapper map, IProduct prd, IOrder ord, IProduct_order pro_ord, Data d)
        {
            this.cust = cust;
            this.map = map;
            this.prd = prd;
            this.ord = ord;
            this.pro_ord = pro_ord;
            this.d = d;
        }
        public IActionResult Index()
        {

            ViewBag.x = TempData["res"];
            return View();

        }
        //this action  get order with max value with details
        public IActionResult GETMAXORDER()
        {
            var data = from customer in d.Customers
                       join order in d.Orders on customer.Custo_Id equals order.customer_id
                       where order.totalPrice.ToString().Equals((from ord in d.Orders select ord.totalPrice).Max().ToString())
                       select new GETMAXORDER { ordernum = order.orderr_num, customername = customer.Name, customerMAil = customer.mail, totalPrice = order.totalPrice };

            return View(data);

        }
        //this action get sum of value of orders in specific month
        public IActionResult GETSumORDER(int month)
        {
            var data = (from order in d.Orders
                        where order.date.Month == month
                        select order.totalPrice).Sum();
            TempData["res"] = data;

            return RedirectToAction("Index");
        }
        //this action get most expensive product
        public IActionResult GETMostProduct()
        {
            var data = (from product in d.Products
                        where product.price.ToString().Equals((from prd in d.Products select prd.price).Max().ToString())
                        select product).AsEnumerable();

            var res = map.Map<IEnumerable<ProductVM>>(data);
            return View(res);

        }
        //this action get each month with total sales based on year
        public IActionResult GETChart(int year)
        {
            var data = ord.GetAll();
            List<int> months = new List<int>();
            for (int i = 1; i <= 12; i++)
            {
                int val = 0;
                foreach (var item in data)
                {
                    if (item.date.Month == i &&item.date.Year==year)
                    {
                        val += item.totalPrice;
                    }
                }
                months.Add(val);
            }


            return View(months);

        }
    }
}
