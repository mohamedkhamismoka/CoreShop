using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication12.BL.Interfaces;
using WebApplication12.DAL.Database;
using WebApplication12.DAL.Entity;

namespace WebApplication12.BL.Reposatory
{


    public class CustomerRepo : ICustomer

    {
        private readonly Data d;

        public CustomerRepo()
        {
        }

        public CustomerRepo(Data d)
        {
            this.d = d;
        }
        //this method to add customer to data base
        public void add(Customer customer)
        {
            d.Customers.Add(customer);
            d.SaveChanges();
        }
        //this method to get all customers from database
        public IEnumerable<Customer> Get()
        {
            var data = d.Customers.Select(a => a);
            return data;
        }
        //this method to get  customers from database by id
        public Customer GetById(int id)
        {
            var data = d.Customers.Find(id);
            return data;
        }
        //this method to remove  customers from database by id
        public void remove(int id)
        {
            var data = d.Customers.Find(id);
            d.Customers.Remove(data);
            d.SaveChanges();
        }
        //this method to update custmomer in data base by id
        //x is id
        //customer is new values
        public void update(int x, Customer customer)
        {
            var data = d.Customers.Find(x);
            d.Entry(data).CurrentValues.SetValues(customer);
            d.SaveChanges();
        }
        //this method is to  get all customers according to filter
        public Customer getbyFilter(Func<Customer, bool> filter = null)
        {

            var data = d.Customers.Where(filter).FirstOrDefault();
            return data;

        }
    }
}
