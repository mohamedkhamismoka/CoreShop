using System.Collections.Generic;
using System.Linq;
using WebApplication12.BL.Interfaces;
using WebApplication12.DAL.Database;
using WebApplication12.DAL.Entity;

namespace WebApplication12.BL.Reposatory
{
    public class BranchRepo : IBranch
    {
        private readonly Data d;
        public BranchRepo(Data d)
        {
            this.d = d;
        }
        //this method to add branch to data base
        public void add(Branch branch)
        {
            d.Branches.Add(branch);
            d.SaveChanges();
        }
        //this method to get all branches from data base
        public IEnumerable<Branch> getAll()
        {
            var data = d.Branches.Select(a => a);
            return data;
        }
        //this method to get  branche from data base by id
        public Branch getBYID(int id)
        {
            var data = d.Branches.Find(id);
            return data;
        }
        //this method to remove branch from data base by id
        public void remove(int id)
        {
            var data = d.Branches.Find(id);
            d.Branches.Remove(data);
            d.SaveChanges();
        }
        //this method to update branch from data base by id
        //x is id
        //branch is new values
        public void update(int id, Branch branch)
        {
            var data = d.Branches.Find(id);
            d.Entry(data).CurrentValues.SetValues(branch);
            d.SaveChanges();
        }
    }
}
