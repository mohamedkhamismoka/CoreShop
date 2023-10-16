using ClosedXML.Excel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using WebApplication12.BL.Interfaces;

namespace WebApplication12.Controllers
{
    [Authorize]
    public class ReportController : Controller
    {// private to be hidden
        //readonly to assign in constructor to achieve DI
        private readonly IOrder ord;
        private readonly ICustomer cust;
        //for dependency injection
        public ReportController(IOrder ord,ICustomer cust)
        {
            this.ord = ord;
            this.cust = cust;
        }
        public IActionResult Index()
        {
            return View();
        }
        //this action take date and get all orders happen in that day as excel file and download it
        public IActionResult Excel(DateTime date)
        {
            var data = ord.getOrderForReport(a => a.date.Month==date.Month & a.date.Day==date.Day&a.date.Year==date.Year);
            using (var ws = new XLWorkbook())
            {
                var worksheet = ws.Worksheets.Add("Report");
                int current_row = 1;
                worksheet.Cell(current_row, 1).Value = "Order Number";
                worksheet.Cell(current_row, 2).Value = "Customer Name";
                worksheet.Cell(current_row, 3).Value = "Total Price";
                worksheet.Cell(current_row, 4).Value = "Date";
                foreach(var item in data)
                {
                    current_row++;
                    worksheet.Cell(current_row, 1).Value = item.orderid;
                    worksheet.Cell(current_row, 2).Value = item.customer.Name;
                    worksheet.Cell(current_row, 3).Value = item.totalPrice;
                    worksheet.Cell(current_row, 4).Value = item.date;

                }

                using(var stream=new MemoryStream())
                {
                    ws.SaveAs(stream);
                    var content=stream.ToArray();
                    return File(
                       content,
                       "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                       "orders for "+date+".xlsx"
                       );
                }

            }

         
        }
    }
}
