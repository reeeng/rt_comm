using Microsoft.EntityFrameworkCore;
using RTComm.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RTComm.Services
{
    public interface IClientService
    {
        Task<List<Client>> Get();
        Task<Client> Get(int id);
        Task<Client> Add(Client client);
        Task<Client> Update(Client client);
        Task<Client> Delete(Client client);
    }
    public class ClientService:IClientService
    {
   
            private readonly ApplicationDbContext _context;

            public ClientService(ApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<List<Client>> Get()
            {
                return await _context.Client.ToListAsync();
            }
            public async Task<Client> Get(int id)
            {
                var client = await _context.Client.FindAsync(id);
                return client;
            }
            public async Task<Client> Add(Client client)
            {
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
            public async Task<Client> Delete(Client client)
            {
                _context.Client.Remove(client);
                await _context.SaveChangesAsync();
                return client;
            }
        }
    }

