using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FitnessGym.Infrastructure.Repository
{
    public interface IRepository<T>
    {
        void Create(T t);
        Task<List<T>> GetAll();
    }
}
