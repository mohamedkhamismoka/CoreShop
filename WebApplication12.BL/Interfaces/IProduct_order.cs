using System.Collections.Generic;
using WebApplication12.DAL.Entity;

namespace WebApplication12.BL.Interfaces
{
    public interface IProduct_order
    {
        void Add(Product_order pro_ord);
        public IEnumerable<Product_order> GetById(int id);
        public IList<Product_order> GetListById(int id);
    }
}
