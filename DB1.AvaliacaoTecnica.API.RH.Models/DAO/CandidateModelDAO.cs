using System.Collections.Generic;
using System.Linq;

namespace DB1.AvaliacaoTecnica.API.RH.Models.DAO
{
    public class CandidateModelDAO
    {
        RHContext context = new RHContext();

        public CandidateModel Get(int id)
        {
            return context.Candidate.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<CandidateModel> GetAll()
        {
            return context.Candidate;
        }

        public void Add(CandidateModel model)
        {
            context.Candidate.Add(model);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.Candidate.Remove(context.Candidate.FirstOrDefault(x => x.Id == id));
            context.SaveChanges();
        }

        public void Update(int id, CandidateModel model)
        {
            var updated = context.Candidate.FirstOrDefault(x => x.Id == model.Id);
            updated.Name = model.Name;
            context.SaveChanges();
        }
    }
}
