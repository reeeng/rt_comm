using Microsoft.EntityFrameworkCore;
using RTComm.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RTComm.Services
{
    public interface IJobService
    {
        Task<List<Jobs>> Get();
        Task<Jobs> Get(int id);
        Task<Jobs> Add(Jobs jobs);
        Task<Jobs> Update(Jobs jobs);
        Task<Jobs> Delete(Jobs jobs);
    }

    public class JobService : IJobService
    {

        private readonly ApplicationDbContext _context;

        public JobService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<Jobs>> Get()
        {
            return await _context.Jobs.ToListAsync();
        }
        public async Task<Jobs> Get(int id)
        {
            var job = await _context.Jobs.FindAsync(id);
            return job;
        }
        public async Task<Jobs> Add(Jobs job)
        {
            _context.Jobs.Add(job);
            await _context.SaveChangesAsync();
            return job;
        }

        public async Task<Jobs> Update(Jobs job)
        {
            _context.Jobs.Update(job);
            await _context.SaveChangesAsync();
            return job;
        }
        public async Task<Jobs> Delete(Jobs job)
        {
            _context.Jobs.Remove(job);
            await _context.SaveChangesAsync();
            return job;
        }
    }

}
