using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication12.BL.Interfaces;
using WebApplication12.DAL.Database;
using WebApplication12.DAL.Entity;

namespace WebApplication12.BL.Reposatory
{
    public class OrderRepo : IOrder
    {
        private readonly Data d;
        public OrderRepo(Data d)
        {
            this.d = d;
        }
        //this method to get all orders from database
        public int Add(order order)
        {
            d.Orders.Add(order);
            d.SaveChanges();
            return d.Orders.OrderByDescending(a=>a.orderid).First().orderid;
        }
        //this method to remove order from database by id
        public void Delete(int id)
        {
            var data = d.Orders.Find(id);
            d.Orders.Remove(data);
            d.SaveChanges();
        }
        //this method to get order from database by id
        public order GetById(int id)
        {
            var data = d.Orders.Find(id);
            return data;
        }

        //this method to update order in database by id
        public void update(order order)
        {
            d.Entry(order).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            d.SaveChanges();
        }
        //this method to get order from database by filter
        public order getspec(Func<order, bool> filter = null)
        {

            var data = d.Orders.Where(filter).FirstOrDefault();
            return data;

        }
        //this method to get orders from database with related customer information
        public IEnumerable<order> getOrderForReport(Func<order, bool> filter = null)
        {

            var data = d.Orders.Include(a=>a.customer).Where(filter);
            return data;

        }
        //this method to get All orders from database
        public IEnumerable<order> GetAll()
        {
            var data = d.Orders.Select(a => a);
            return data;
        }
        
    }
}
