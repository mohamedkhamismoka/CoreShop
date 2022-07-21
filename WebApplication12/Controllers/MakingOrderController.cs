using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using WebApplication12.BL.Interfaces;
using WebApplication12.BL.VM;
using WebApplication12.DAL.Entity;

namespace WebApplication12.Controllers
{
    [Authorize]
    public class MakingOrderController : Controller
    {// private to be hidden
        //readonly to assign in constructor to achieve DI
        private readonly ICustomer cust;
        private readonly IMapper map;
        private readonly IProduct prd;
        private readonly IOrder ord;
        private readonly IProduct_order pro_ord;


        //for dependency injection
        public MakingOrderController(ICustomer cust, IMapper map, IProduct prd, IOrder ord, IProduct_order pro_ord)
        {
            this.cust = cust;
            this.map = map;
            this.prd = prd;
            this.ord = ord;
            this.pro_ord = pro_ord;
        }
        public IActionResult Index()
        {
            ViewBag.warn = TempData["warn"];
            return View();
        }
        [HttpPost]
        //this action check phonr number if true go to make order else go back 
        public IActionResult direct(string phone)
        {
            var data = cust.getbyFilter(a => a.phone == phone);
            if (data != null)
            {
                TempData["cust"] = data.Custo_Id;
                return RedirectToAction("startWork");
            }
            else
            {
                TempData["warn"] = phone + " is Not valid phone number";
                return RedirectToAction("Index");
            }
        }

        public IActionResult startWork()
        {
            int id = Convert.ToInt32(TempData["cust"]);
            var data = cust.getbyFilter(a => a.Custo_Id == id);
            var data2 = map.Map<CustomerVM>(data);
            //this line show fill select list with products id
            ViewBag.products = new SelectList(prd.getEnum(a => a.quantity > 0), "Id", "Id");
            return View(data2);
        }

        [HttpPost]
        //gave data to ajax to calculate total price of product based on quantity
        public JsonResult GetData(int prdid, int quantity)
        {
           
            var data = prd.GEtById(prdid);
            int price = data.price;
            int totalPrice = price * quantity;
            string name = data.Name;
            if (data.quantity >= quantity)
            {
               
                return Json(new {code=1, totalPrice = totalPrice, name = name });
            }
            else
            {
                return Json(new { code=2, totalPrice = totalPrice, name = name });
            }
   

        }
      
        [HttpPost]
        //this action take products and and quantity of each product  to make order and log products of order in Product_order Entity
        public JsonResult Confirm(int id, int totalprice, int[] products, int[] quan)
        {
            //for (int i = 0; i < products.Length; i++)
            //{
            //    prd.decrement(products[i], quan[i]);
            //}
            OrderVM order = new OrderVM();
            order.customer_id = id;
            order.totalPrice = totalprice;
            order.date = DateTime.Now.Date;
            var data = map.Map<order>(order);
           int orderNO= ord.Add(data);
            //int order_num = ord.GetLast();
            Product_orderVM pr = new Product_orderVM();
            pr.ord_id = orderNO;
            pr.date = DateTime.Now.Date;
            for (int i = 0; i < products.Length; i++)
            {
                pr.pro_id = products[i];
                pr.quantity = quan[i];
                var res=map.Map<Product_order>(pr);
                pro_ord.Add(res);
            }

            return Json(new { orderno = orderNO});
        }
      //to get order details
        public IActionResult GetorderData()
        {
            ViewBag.warn = TempData["warn"];
            return View();
        }
        [HttpPost]
        //to get order details based on order number if order number exst
        public IActionResult GetorderData(int orderr_num)
        {
            
                var data=ord.getspec(a=>a.orderr_num==orderr_num);
                if (data != null)
                {
                var res = map.Map<OrderVM>(data);
                    return RedirectToAction("ShowOrder", new{ orderNo = res.orderr_num});
                }
                else
                {
                    TempData["warn"] = "not found order";
                    return RedirectToAction("GetorderData");
                }
            
         
        }
        //recieve data from Getorderdata action and showw it 

        public IActionResult ShowOrder(int orderNo)
        {
            var data = pro_ord.GetById(orderNo);
            var res = map.Map<IList<Product_orderVM>>(data);

            int totalPrice = 0;
            foreach (var item in res)
            {
                totalPrice += item.product.price * item.quantity;
            }
            ViewBag.total = totalPrice;
          int customerID= ord.GetById(orderNo).customer_id;
            ViewBag.customerName = cust.GetById(customerID).Name;
            ViewBag.customerphone = cust.GetById(customerID).phone;
            ViewBag.customermail = ord.GetById(orderNo).customer.mail;
            return View(res);

        }

    }
}
