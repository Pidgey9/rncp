using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using elearning.Models;

namespace elearning.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class AvancementController : ApiController
    {
        // GET: api/Personne
        public List<Avancement> Get()
        {
            return new DaoAvancement().SelectAll();
        }

        // GET: api/Personne/5
        public Avancement Get(int id)
        {
            return new DaoAvancement().SelectById(id);
        }

        // POST: api/Personne insert
        public bool Post([FromBody]Avancement p)
        {
            return new DaoAvancement().Insert(p);
        }

        // PUT: api/Personne/5 update
        public bool Put(int id, [FromBody]Avancement p)
        {
            return new DaoAvancement().Update(p);
        }

        // DELETE: api/Personne/5
        public bool Delete(int id)
        {
            return new DaoAvancement().Delete(id);
        }
    }
}
