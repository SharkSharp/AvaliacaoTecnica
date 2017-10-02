using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB1.AvaliacaoTecnica.API.RH.Models
{
    [Table("JobOportunity")]
    public class JobOportunityModel
    {
        [Key]
        [Required]
        [Index(IsUnique = true)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Insira o Nome!")]
        [Display(Name = "Nome:")]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        public ICollection<InterviewModel> Interviews { get;set; }
    }
}