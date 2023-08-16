using AutoMapper;
using Org.BouncyCastle.Bcpg;
using WebApplication12.BL.VM;
using WebApplication12.DAL;
using WebApplication12.DAL.Entity;

namespace WebApplication12.BL.Automapper
{
    public class DomainProfile : Profile
    {
        
        public DomainProfile()
        {
            CreateMap<CustomerVM, Customer>();
            CreateMap<Customer, CustomerVM>();
            CreateMap<Branch, BranchVM>();
            CreateMap<BranchVM, Branch>();
            CreateMap<Product, ProductVM>();
            CreateMap<ProductVM, Product>();
            CreateMap<order, OrderVM>();
            CreateMap<OrderVM, order>();
            CreateMap<Product_order, Product_orderVM>();
            CreateMap<Product_orderVM, Product_order>();
        }
    }
}
