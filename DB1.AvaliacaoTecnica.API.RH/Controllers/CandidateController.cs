using DB1.AvaliacaoTecnica.API.RH.Models;
using DB1.AvaliacaoTecnica.API.RH.Models.DAO;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Results;


namespace DB1.AvaliacaoTecnica.API.RH.Controllers
{
    public class CandidateController : ApiController
    {
        // GET: api/Candidate
        public JsonResult<List<CandidateModel>> Get()
        {
            CandidateModelDAO dao = new CandidateModelDAO();
            return Json(dao.GetAll().ToList());
        }

        // GET: api/Candidate/5
        public JsonResult<CandidateModel> Get(int id)
        {
            CandidateModelDAO dao = new CandidateModelDAO();
            return Json(dao.Get(id));
        }

        // POST: api/Candidate
        public void Post([FromBody]CandidateModel value)
        {
            CandidateModelDAO dao = new CandidateModelDAO();
            dao.Add(value);
        }

        // PUT: api/Candidate/5
        public void Put([FromBody]CandidateModel value)
        {
            CandidateModelDAO dao = new CandidateModelDAO();
            dao.Update(value.Id, value);
        }

        // DELETE: api/Candidate/5
        public void Delete(int id)
        {
            CandidateModelDAO dao = new CandidateModelDAO();
            dao.Delete(id);
        }
    }
}
