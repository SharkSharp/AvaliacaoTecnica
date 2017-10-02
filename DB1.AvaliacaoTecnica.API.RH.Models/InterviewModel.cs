using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB1.AvaliacaoTecnica.API.RH.Models
{
    [Table("Interview")]
    public class InterviewModel
    {
        [Key]
        [Required]
        [Index(IsUnique = true)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public virtual CandidateModel Candidate { get; set; }

        public virtual JobOportunityModel JobOportunity { get; set; }

        public virtual ICollection<InterviewTechnologyModel> Technologies { get; set; }
    }

    [Table("InterviewTechnology")]
    public class InterviewTechnologyModel
    {
        [Key]
        [Required]
        [Index(IsUnique = true)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public virtual InterviewModel Interview { get; set; }

        public virtual TechnologyModel Technology { get; set; }
    }
}