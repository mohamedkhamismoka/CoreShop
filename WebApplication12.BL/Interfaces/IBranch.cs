using System.Collections.Generic;
using WebApplication12.DAL.Entity;

namespace WebApplication12.BL.Interfaces
{
    public interface IBranch
    {
        IEnumerable<Branch> getAll();
        Branch getBYID(int id);
        void add(Branch branch);
        void remove(int id);
        void update(int id, Branch branch);
    }
}
