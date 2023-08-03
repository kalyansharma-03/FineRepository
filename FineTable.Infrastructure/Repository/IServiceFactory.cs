using FineTable.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FineTable.Infrastructure.Repository
{
    public interface IServiceFactory
    {
        IServiceRepository<t> GetInstance<t>() where t : class;

        void BeginTransaction();

        void RollBack();

        void CommitTransaction();
    }
}
