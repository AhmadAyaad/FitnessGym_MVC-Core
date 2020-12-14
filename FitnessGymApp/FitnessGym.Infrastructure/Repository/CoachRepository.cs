using FitnessGym.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FitnessGym.Infrastructure.Repository
{
    public class CoachRepository : IRepository<Coach>, IGetByNameRepository<Coach>
    {
        readonly DataContext _context;
        public CoachRepository(DataContext context)
        {
            _context = context;
        }
        public async Task Create(Coach coach)
        {
            if (coach != null)
            {
                _context.Coaches.Add(coach);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Coach>> GetAll()
        {

            var coaches = await _context.Coaches.ToListAsync();
            if (coaches != null)
                return coaches;
            return new List<Coach>();
        }

        public async Task<Coach> GetByName(string name)
        {
            var coach = await _context.Coaches.FirstOrDefaultAsync(c => c.CoachName == name);
            if (coach != null)
                return coach;
            return new Coach();
        }
    }
}
