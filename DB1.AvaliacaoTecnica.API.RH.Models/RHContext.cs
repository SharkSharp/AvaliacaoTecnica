using System.Data.Entity;

namespace DB1.AvaliacaoTecnica.API.RH.Models
{
    class RHContext : DbContext
    {
        public DbSet<TechnologyModel> Technology { get; set; }
        public DbSet<CandidateModel> Candidate { get; set; }
        public DbSet<JobOportunityModel> JobOportunity { get; set; }
        public DbSet<InterviewModel> Interview { get; set; }
        public DbSet<InterviewTechnologyModel> InterviewTechnology { get; set; }
    }
}
