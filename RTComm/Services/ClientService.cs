using Microsoft.EntityFrameworkCore;
using RTComm.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RTComm.Services
{
    public interface IClientService  //Entities that implement the interface must define functionalities declared in the interface
    {
        Task<List<Client>> Get();
        Task<Client> Get(int id);
        Task<Client> Add(Client client);
        Task<Client> Update(Client client);
        Task<bool> Delete(Client client);
    }
    public class ClientService : IClientService  //as this is inheriting from the interface, it MUST DEFINE the get,add,update,delete tasks specified ... it isn't necessary but i mean it's good practice IG
    {

        private readonly ApplicationDbContext _context;

        public ClientService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<Client>> Get()
        {

            return await _context.Client.Where(client => client.IsActive).Include(client => client.Jobs).ToListAsync(); //fetches clients where IsActive is true, and inludes the joblist within the fetch)
        }
        public async Task<Client> Get(int id)
        {
            var client = await _context.Client.FindAsync(id); 
            return client;
        }
        public async Task<Client> Add(Client client) 
        {
            client.IsActive = true;//making sure that client.IsActive is set to true when adding a new client
            _context.Client.Add(client);
            await _context.SaveChangesAsync();
            return client;
        }

        public async Task<Client> Update(Client client)
        {
            _context.Client.Update(client);
            await _context.SaveChangesAsync();
            return client;
        }
        public async Task<bool> Delete(Client client) 
        {
            
            if (!client.Jobs.Any(job => job.IsActive))//if client.jobs has no entries (note the !), then it twill set is active to false and it will no longer be fetched by the clientservice.get
            {
                client.IsActive = false; //sets isactive to false if no jobs
                await _context.SaveChangesAsync(); //saves changes
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}

