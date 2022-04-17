using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication12.BL.Interfaces;
using WebApplication12.DAL.Database;
using WebApplication12.DAL.Entity;

namespace WebApplication12.BL.Reposatory
{


    public class ProductRepo : IProduct
    {
        private readonly Data d;
        public ProductRepo(Data d)
        {
            this.d = d;
        }
      
        //this method to add product  to database
        public void add(Product prd)
        {
            d.Products.Add(prd);
            d.SaveChanges();
        }

        //this method to remove product from database
        public void delete(int id)
        {
            var data = d.Products.Find(id);
            d.Products.Remove(data);
            d.SaveChanges();
        }
        //this method to get all product from database
        public IEnumerable<Product> GET()
        {
            var data = d.Products.Select(a => a);
            return data;
        }
        //this method to get product from database by id
        public Product GEtById(int id)
        {
            var data = d.Products.Find(id);
            return data;
        }
        //this method to update product in data base by id
        //id is id
        //prd object contain new values
        public void update(Product prd, int id)
        {
            var data = d.Products.Find(id);
            d.Entry(data).CurrentValues.SetValues(prd);
            d.SaveChanges();
        }
        //this method to get only one product  in data base by filter
        public Product getbyfilter(Func<Product, bool> filter = null)
        {

            var data = d.Products.Where(filter).FirstOrDefault();
            return data;

        }
        //this method to get all product  in data base by filter
        public IEnumerable<Product> getEnum(Func<Product, bool> filter = null)
        {

            var data = d.Products.Where(filter);
            return data;

        }
        //this method to get increase product quantity  in data base 
        public void increment(int id, int quantity)
        {
            var data = d.Products.Find(id);
            data.quantity = data.quantity + quantity;
            d.SaveChanges();
        }
        //this method to get reduce product quantity  in data base 
        public void decrement(int id, int quantity)
        {
            var data = d.Products.Find(id);
            data.quantity = data.quantity - quantity;
            d.SaveChanges();
            d.Dispose();
        }
    }
}
