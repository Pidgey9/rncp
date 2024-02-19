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
    public class UtilisateurController : ApiController
    {
        // GET: api/Personne
        public List<Utilisateur> Get()
        {
            return new DaoUtilisateur().SelectAll();
        }

        // GET: api/Personne/5
        public Utilisateur Get(int id)
        {
            return new DaoUtilisateur().SelectById(id);
        }

        // POST: api/Personne insert
        public bool Post([FromBody]Utilisateur p)
        {
            return new DaoUtilisateur().Insert(p);
        }

        // PUT: api/Personne/5 update
        public bool Put(int id, [FromBody]Utilisateur p)
        {
            return new DaoUtilisateur().Update(p);
        }

        // DELETE: api/Personne/5
        public bool Delete(int id)
        {
            return new DaoUtilisateur().Delete(id);
        }
    }
}
