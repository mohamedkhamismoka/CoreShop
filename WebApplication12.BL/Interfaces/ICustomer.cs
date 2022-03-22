﻿using System;
using System.Collections.Generic;
using WebApplication12.DAL.Entity;

namespace WebApplication12.BL.Interfaces
{
    public interface ICustomer
    {
        IEnumerable<Customer> Get();
        Customer GetById(int id);
        void add(Customer customer);
        void remove(int id);
        void update(int x, Customer customer);
        Customer get(Func<Customer, bool> filter = null);
    }
}
