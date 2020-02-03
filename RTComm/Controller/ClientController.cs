using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RTComm.Data;
using Microsoft.EntityFrameworkCore;

namespace RTComm.Controller
{
    public class ClientController : ControllerBase //think this base class gives all functionality for a service layer class
    {
        private readonly ApplicationDbContext context; //putting dbcontext in controller
        public ClientController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet] // tryna list all clients in db
        public async Task<ActionResult<List<Client>>> Get()
        {
            return await context.Client.ToListAsync();
        }

       [HttpGet("{id}", Name ="GetClient")] //get a specific ID
       public async Task<ActionResult<Client>> Get(int id) 
        {
            return await context.Client.FirstOrDefaultAsync(x => x.Id == id); //Asynchronously returns the first element of a sequence, or a default value if the sequence contains no elements.
        }

        [HttpPost]
        public async Task<ActionResult> Post(Client client)
        {
            context.Add(client);
            await context.SaveChangesAsync();//asynchronously saves all changes made in this context to the underlying database.
            return new CreatedAtRouteResult("GetClient", new { id = client.Id }, client);
           // createdatrouteresult is actionmethod that returns a Created response with a Location header.
        }

        [HttpPost]
        public async Task<ActionResult> Put(Client client)
        {
            context.Entry(client).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }
        
        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            var client = new Client { Id = id };
            context.Remove(client);
            await context.SaveChangesAsync();
            return NoContent();

        }
    }

}
