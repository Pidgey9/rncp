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
    public class QuizController : ApiController
    {
        // GET: api/Personne
        public List<Quiz> Get()
        {
            return new DaoQuiz().SelectAll();
        }

        // GET: api/Personne/5
        public Quiz Get(int id)
        {
            return new DaoQuiz().SelectById(id);
        }

        // POST: api/Personne insert
        public bool Post([FromBody]Quiz p)
        {
            return new DaoQuiz().Insert(p);
        }

        // PUT: api/Personne/5 update
        public bool Put(int id, [FromBody]Quiz p)
        {
            return new DaoQuiz().Update(p);
        }

        // DELETE: api/Personne/5
        public bool Delete(int id)
        {
            return new DaoQuiz().Delete(id);
        }
    }
}
