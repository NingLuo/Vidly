using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vidly.Core.Repositories;
using Vidly.Models;

namespace Vidly.Core
{
    public interface IUnitOfWork
    {
        IMovieRepository Movies { get; }
        ICustomerRepository Customers { get; }
        int Complete();
    }
}
