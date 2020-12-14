using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FitnessGym.Infrastructure.Repository
{
    public interface IRepository<T>
    {
        Task Create(T t);
        Task<List<T>> GetAll();
    }
}
