using ExpressStore.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressStore.Infrastructure.Data
{
    public interface IRepository<T> : IRepositoryWithTypedId<T,long> where T : IEntityWithTypedId<long>
    {
    }
}
