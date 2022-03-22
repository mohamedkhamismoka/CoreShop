using System;
using System.Collections.Generic;
using WebApplication12.DAL.Entity;

namespace WebApplication12.BL.Interfaces
{
    public interface IProduct
    {
        IEnumerable<Product> GET();
        Product GEtById(int id);
        void add(Product prd);
        void update(Product prd, int id);
        void delete(int id);
        Product get(Func<Product, bool> filter = null);
        void increment(int id, int quantity);
        void decrement(int id, int quantity);
        IEnumerable<Product> getEnum(Func<Product, bool> filter = null);
    }
}
