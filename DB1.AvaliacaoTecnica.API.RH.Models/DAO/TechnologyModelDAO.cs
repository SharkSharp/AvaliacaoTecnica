using System;
using System.Collections.Generic;
using System.Linq;

namespace DB1.AvaliacaoTecnica.API.RH.Models.DAO
{
    public class TechnologyModelDAO
    {
        RHContext context = new RHContext();

        public IEnumerable<TechnologyModel> GetAll()
        {
            return context.Technology;
        }

        public void Add(TechnologyModel model)
        {
            context.Technology.Add(model);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.Technology.Remove(context.Technology.FirstOrDefault(x => x.Id == id));
            context.SaveChanges();
        }

        public void Update(int id, TechnologyModel model)
        {
            var updated = context.Technology.FirstOrDefault(x => x.Id == model.Id);
            updated.Name = model.Name;
            context.SaveChanges();
        }

        public TechnologyModel Get(int id)
        {
            return context.Technology.FirstOrDefault(x => x.Id == id);
        }
    }
}
