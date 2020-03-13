using Microsoft.EntityFrameworkCore;
using RTComm.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RTComm.Services
{
    public interface IConstructionService
    {
        Task<List<ConstructionCo>> Get();
        Task<ConstructionCo> Get(int id);
        Task<ConstructionCo> Add(ConstructionCo constructionCo);
        Task<ConstructionCo> Update(ConstructionCo constructionCo);
        Task<ConstructionCo> Delete(ConstructionCo constructionCo);
    }
    public class ConstructionCoService : IConstructionService
    {
        private readonly ApplicationDbContext _context;

        public ConstructionCoService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<ConstructionCo>> Get()
        {
            
            return await _context.ConstructionCo.Where(constructionco => constructionco.IsActive).ToListAsync();
        }
        public async Task<ConstructionCo> Get(int id)
        {
            var constructionCo = await _context.ConstructionCo.FindAsync(id);
            return constructionCo;
        }
        public async Task<ConstructionCo> Add(ConstructionCo constructionCo)
        {
            constructionCo.IsActive = true;
            _context.ConstructionCo.Add(constructionCo);
            await _context.SaveChangesAsync();
            return constructionCo;
        }

        public async Task<ConstructionCo> Update(ConstructionCo constructionCo)
        {
            _context.ConstructionCo.Update(constructionCo);
            await _context.SaveChangesAsync();
            return constructionCo;
        }
        public async Task<ConstructionCo> Delete(ConstructionCo constructionCo)
        {
            constructionCo.IsActive = false;
            await _context.SaveChangesAsync();
            return constructionCo;
        }
    }
}
