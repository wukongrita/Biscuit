using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Biscuit.DbContexts;
using Biscuit.Models;

namespace Biscuit.Controllers.Core
{
    [Route("core/[controller]")]
    public class TenantsController : Controller
    {
        private readonly PostgreContext _context;
        public TenantsController(PostgreContext context)
        {
            _context= context;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Models.Core.Tenant> Get()
        {
            return _context.Tenants.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
