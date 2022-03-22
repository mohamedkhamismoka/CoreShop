using System;
using System.Collections.Generic;
using WebApplication12.DAL.Entity;

namespace WebApplication12.BL.Interfaces
{
    public interface IOrder
    {
        IEnumerable<order> GetAll();
        int Add(order order);
        void Delete(int id);
        void update(order order);
        order GetById(int id);
        public order getspec(Func<order, bool> filter = null);
        public IEnumerable<order> getOrderForReport(Func<order, bool> filter = null);
    }
}
