using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication12.DAL.Entity;

namespace WebApplication12.DAL.Database
{
    public class Data : IdentityDbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=DESKTOP-F7S9FSJ;Initial Catalog=Mohamadia;Integrated Security=True;Pooling=False");
        //}

        //connection string enhancement
        public Data(DbContextOptions<Data> opt) : base(opt)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //composite primary key
            modelBuilder.Entity<Product_order>().HasKey(a => new { a.ord_id, a.pro_id });
       

        }

        public DbSet<Branch> Branches { get; set; }
        public DbSet<Customer> Customers { get; set; }


        public DbSet<order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Product_order> product_Orders { get; set; }
    }
}
