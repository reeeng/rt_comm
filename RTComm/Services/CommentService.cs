using Microsoft.EntityFrameworkCore;
using RTComm.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RTComm.Services
{
    public interface ICommentService
    {
        Task<List<Comments>> Get();
        Task<Comments> Get(int id);
        Task<Comments> Add(Comments comment);
        Task<Comments> Update(Comments comment);
        Task<Comments> Delete(Comments comment);
    }
    public class CommentService : ICommentService
    {
        private readonly ApplicationDbContext _context;

        public CommentService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<Comments>> Get()
        {
            return await _context.Comments.ToListAsync();
        }
        public async Task<Comments> Get(int id)
        {
            var comment = await _context.Comments.FindAsync(id);
            return comment;
        }
        public async Task<Comments> Add(Comments comment)
        {
            _context.Comments.Add(comment);
            await _context.SaveChangesAsync();
            return comment;
        }

        public async Task<Comments> Update(Comments comment)
        {
            _context.Comments.Update(comment);
            await _context.SaveChangesAsync();
            return comment;
        }
        public async Task<Comments> Delete(Comments comment)
        {
            _context.Comments.Remove(comment);
            await _context.SaveChangesAsync();
            return comment;
        }
    }
}
