using DB1.AvaliacaoTecnica.API.RH.Models;
using DB1.AvaliacaoTecnica.API.RH.Models.DAO;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Results;

namespace DB1.AvaliacaoTecnica.API.RH.Controllers
{
    public class JobOportunityController : ApiController
    {
        // GET: api/JobOportunity
        public JsonResult<List<JobOportunityModel>> Get()
        {

            JobOportunityModelDAO dao = new JobOportunityModelDAO();

            return Json(dao.GetAll().ToList());
        }

        // GET: api/JobOportunity/5
        public JsonResult<JobOportunityModel> Get(int id)
        {
            JobOportunityModelDAO dao = new JobOportunityModelDAO();
            return Json(dao.Get(id));
        }

        [Route("api/JobOportunity/Report/{id}")]
        public JsonResult<List<CandidateGrade>> Report(int id, [FromBody]List<TechnologyGrade> grades)
        {
            JobOportunityModelDAO dao = new JobOportunityModelDAO();
            var job = dao.GetComplete(id);

            var ret = new List<CandidateGrade>();

            foreach (var item in job.Interviews)
            {
                var atual = new CandidateGrade();
                atual.Candidate = item.Candidate;
                var specs = item.Technologies.Select(x => x.Technology.Id);
                foreach (var tech in grades)
                {
                    if (specs.Contains(tech.Id))
                    {
                        atual.Grade += tech.Grade;
                    }
                }
                ret.Add(atual);
            }

            ret.Sort((a, b) => b.Grade.CompareTo(a.Grade));
            return Json(ret);
        }

        // POST: api/JobOportunity
        public void Post([FromBody]JobOportunityModel value)
        {
            JobOportunityModelDAO dao = new JobOportunityModelDAO();
            dao.Add(value);
        }

        // PUT: api/JobOportunity/5
        public void Put([FromBody]JobOportunityModel value)
        {
            JobOportunityModelDAO dao = new JobOportunityModelDAO();
            dao.Update(value.Id, value);
        }

        // DELETE: api/JobOportunity/5
        public void Delete(int id)
        {
            JobOportunityModelDAO dao = new JobOportunityModelDAO();
            dao.Delete(id);
        }
    }
}
