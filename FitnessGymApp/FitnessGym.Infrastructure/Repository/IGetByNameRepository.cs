using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FitnessGym.Infrastructure.Repository
{
    public interface IGetByNameRepository<T>
    {
        Task<T> GetByName(string name);
    }
}
