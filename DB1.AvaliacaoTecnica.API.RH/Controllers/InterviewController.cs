using DB1.AvaliacaoTecnica.API.RH.Models;
using DB1.AvaliacaoTecnica.API.RH.Models.DAO;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Results;


namespace DB1.AvaliacaoTecnica.API.RH.Controllers
{
    public class InterviewController : ApiController
    {
        // GET: api/Interview        // POST: api/Interview
        public void Post([FromBody]InterviewModel value)
        {
            InterviewModelDAO dao = new InterviewModelDAO();
            dao.Add(value);
        }

    }
}
