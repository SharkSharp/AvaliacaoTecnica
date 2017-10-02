using System.Collections.Generic;
using System.Linq;

namespace DB1.AvaliacaoTecnica.API.RH.Models.DAO
{
    public class InterviewModelDAO
    {
        RHContext context = new RHContext();

        public void Add(InterviewModel model)
        {
            model.Candidate = context.Candidate.FirstOrDefault(x => x.Id == model.Candidate.Id);
            model.JobOportunity = context.JobOportunity.FirstOrDefault(x => x.Id == model.JobOportunity.Id);

            foreach (var item in model.Technologies)
            {
                item.Interview = model;
                item.Technology = context.Technology.FirstOrDefault(x => x.Id == item.Technology.Id);
            }

            context.Interview.Add(model);
            context.SaveChanges();
        }
    }
}
