using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Infrastructure.Repositories.interfaces
{
    public interface ICustomerRepository<T> where T : class
    {
        Task AddCustomerAsync(T customer);
    }
}
