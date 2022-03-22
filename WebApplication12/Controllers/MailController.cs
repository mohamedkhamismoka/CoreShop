using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using WebApplication12.BL.Interfaces;
using WebApplication12.BL.VM;
using WebApplication12.DAL.Entity;

namespace WebApplication12.Controllers
{
    public class MailController : Controller
    {  // private to be hidden
        //readonly to assign in constructor to achieve DI
        private readonly ICustomer cust;
        private readonly IMapper map;
        private readonly IProduct prd;
        private readonly IOrder ord;
        private readonly IProduct_order pro_ord;



        //for dependency injection
        public MailController(ICustomer cust, IMapper map, IProduct prd, IOrder ord, IProduct_order pro_ord)
        {
            this.cust = cust;
            this.map = map;
            this.prd = prd;
            this.ord = ord;
            this.pro_ord = pro_ord;
        }


        /*this action recieve id of product_order
         * and loop on data to get to total price 
         * and show order details before confirmation and sending mail*/
       
        public IActionResult Index(int id)
        {
            var data = pro_ord.GetById(id);
            var res = map.Map<IEnumerable<Product_orderVM>>(data);
            int totalPrice = 0;
            foreach (var item in res)
            {
                totalPrice += item.product.price * item.quantity;
            }
            ViewBag.total = totalPrice;
            var mm = ord.getspec(a => a.orderr_num == id);
            var idd = mm.customer_id;
            var custo = cust.GetById(idd);

            ViewBag.mail = custo.mail;
            ViewBag.orderNo = id;
            return View(res);
        }

        /* after confirmation convert table to bytes and send data as an email */
        [HttpPost]

        public IActionResult send(string tblHtml, string mail,int orderNo)
        {


                if (tblHtml != null)
                {
                 var res = pro_ord.GetListById(orderNo);
                   
                    var name = cust.get(a => a.mail == mail).Name;
                    byte[] bytes = Encoding.ASCII.GetBytes(tblHtml);
                    MailMessage mm = new MailMessage("atiffahmykhamis@gmail.com", mail);

                    mm.Subject = "Thank Your MR " + name + " for your Visit here your order  Bill Details orderNo" + orderNo.ToString() + "";
                    mm.Body = tblHtml;
                    //mm.Attachments.Add(new Attachment(new MemoryStream(bytes), " Your_Order.xls"));
                    mm.IsBodyHtml = true;
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.EnableSsl = true;
                    System.Net.NetworkCredential credentials = new System.Net.NetworkCredential();
                    credentials.UserName = "atiffahmykhamis@gmail.com";
                    credentials.Password = "01065578456M";
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = credentials;
                    smtp.Port = 587;
                    try
                    {
                        smtp.Send(mm);
                        smtp.Dispose();
                        foreach (var item in res)
                        {
                            prd.decrement(item.pro_id, item.quantity);
                        }
                        return RedirectToAction("Index", "Home");
                    }catch (Exception ex)
                    {
                        var num = orderNo;
                        TempData["x"] = "there is error";
                        return RedirectToAction("Index", new { id = num });
                    }
                }
                var data = orderNo;
                TempData["x"] = "there is error";
                return RedirectToAction("Index", new { id = data });
            }
            




        


    }
}

