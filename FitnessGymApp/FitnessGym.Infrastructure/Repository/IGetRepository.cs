using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FitnessGym.Infrastructure.Repository
{
    public interface IGetRepository<T>
    {
        Task<List<T>> GetAll();
    }
}
