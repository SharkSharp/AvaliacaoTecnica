using DB1.AvaliacaoTecnica.API.RH.Models;
using DB1.AvaliacaoTecnica.API.RH.Models.DAO;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Results;

namespace DB1.AvaliacaoTecnica.API.RH.Controllers
{
    public class TechnologyController : ApiController
    {
        // GET: api/Technology
        public JsonResult<List<TechnologyModel>> Get()
        {
            TechnologyModelDAO dao = new TechnologyModelDAO();

            return Json(dao.GetAll().ToList());
        }

        // GET: api/Technology/5
        public JsonResult<TechnologyModel> Get(int id)
        {
            TechnologyModelDAO dao = new TechnologyModelDAO();
            return Json(dao.Get(id));
        }

        // POST: api/Technology
        public void Post([FromBody]TechnologyModel value)
        {
            TechnologyModelDAO dao = new TechnologyModelDAO();
            dao.Add(value);
        }

        // PUT: api/Technology/5
        public void Put([FromBody]TechnologyModel value)
        {
            TechnologyModelDAO dao = new TechnologyModelDAO();
            dao.Update(value.Id, value);
        }

        // DELETE: api/Technology/5
        public void Delete(int id)
        {
            TechnologyModelDAO dao = new TechnologyModelDAO();
            dao.Delete(id);
        }
    }
}
