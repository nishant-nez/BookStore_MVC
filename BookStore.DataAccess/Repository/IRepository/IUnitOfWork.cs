using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        // creating global save method as it is same for all the repositories
        ICategoryRespository Category { get; }
        void Save();
    }
}
