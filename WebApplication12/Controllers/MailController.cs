using AutoMapper;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System;
using System.Collections.Generic;

using System.Text;
using System.Threading.Tasks;
using WebApplication12.BL.Interfaces;
using WebApplication12.BL.VM;
using WebApplication12.DAL.Entity;

namespace WebApplication12.Controllers
{
    [Authorize]
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

        public async Task<IActionResult> send(string tblHtml, string mail,int orderNo)
        {


                if (tblHtml != null)
                {
                 var res = pro_ord.GetListById(orderNo);
                   
                    var name = cust.getbyFilter(a => a.mail == mail).Name;
                    byte[] bytes = Encoding.ASCII.GetBytes(tblHtml);
                
                var email = new MimeMessage()
                {
                    Sender = MailboxAddress.Parse("atiffahmykhamis@gmail.com"),
                    Subject= "Thank Your MR " + name + " for your Visit here your order  Bill Details orderNo" + orderNo.ToString() + ""


                };
                email.To.Add(MailboxAddress.Parse(mail));
                var builder = new BodyBuilder();

                builder.HtmlBody = tblHtml;

                email.Body = builder.ToMessageBody();

                email.From.Add(new MailboxAddress("El-mohamadia Co", "atiffahmykhamis@gmail.com"));


                try
                {
                    using (var smtp = new SmtpClient())
                    {
                        smtp.Connect("smtp.gmail.com", 587, false);
                        smtp.Authenticate("atiffahmykhamis@gmail.com", "orgfcydfvpbjgyvl");
                        await smtp.SendAsync(email);
                        smtp.Disconnect(true);
                    }
                    foreach (var item in res)
                    {
                        prd.decrement(item.pro_id, item.quantity);
                    }
                    return RedirectToAction("Index", "Home");
                }
                catch (Exception ex)
                {
                    var num = orderNo;
                    TempData["x"] = "there is error";
                    return RedirectToAction("Index", new { id = num });
                }
            }
            else
            {
                var data = orderNo;
                TempData["x"] = "there is error";
                return RedirectToAction("Index", new { id = data });
            }
    
            }
            




        


    }
}

