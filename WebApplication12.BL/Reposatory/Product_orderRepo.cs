using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebApplication12.BL.Interfaces;
using WebApplication12.DAL.Database;
using WebApplication12.DAL.Entity;

namespace WebApplication12.BL.Reposatory
{
    public class Product_orderRepo : IProduct_order
    {
        private readonly Data d;
        public Product_orderRepo(Data d)
        {
            this.d = d;
        }
        //this method to add row to database
        public void Add(Product_order pro_ord)
        {
            d.product_Orders.Add(pro_ord);
            d.SaveChanges();
        }
        //this method to get all arows from database
        public IEnumerable<Product_order> GetById(int id)
        {
            var data = d.product_Orders.Include(a => a.product).Include(a => a.orders).Where(a => a.ord_id == id);
            return data;
        }

        //this method to get all arows from database and retrurn list to solve problem of save changes during foreach loop in mail controller send action
        public IList<Product_order> GetListById(int id)
        {
            var data = d.product_Orders.Include(a => a.product).Include(a => a.orders).Where(a => a.ord_id == id).ToList();
            return data;
        }
    }
}
