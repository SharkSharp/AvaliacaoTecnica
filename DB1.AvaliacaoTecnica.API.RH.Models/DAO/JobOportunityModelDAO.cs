using System;
using System.Collections.Generic;
using System.Linq;

namespace DB1.AvaliacaoTecnica.API.RH.Models.DAO
{
    public class JobOportunityModelDAO
    {
        RHContext context = new RHContext();

        public IEnumerable<JobOportunityModel> GetAll()
        {
            return context.JobOportunity;
        }

        public void Add(JobOportunityModel model)
        {
            context.JobOportunity.Add(model);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.JobOportunity.Remove(context.JobOportunity.FirstOrDefault(x => x.Id == id));
            context.SaveChanges();
        }

        public void Update(int id, JobOportunityModel model)
        {
            var updated = context.JobOportunity.FirstOrDefault(x => x.Id == model.Id);
            updated.Name = model.Name;
            context.SaveChanges();
        }

        public JobOportunityModel Get(int id)
        {
            return context.JobOportunity.FirstOrDefault(x => x.Id == id);
        }

        public JobOportunityModel GetComplete(int id)
        {
            var ret = context.JobOportunity.FirstOrDefault(x => x.Id == id);
            context.Entry(ret).Collection(x => x.Interviews).Load();
            return ret;
        }
    }
}
