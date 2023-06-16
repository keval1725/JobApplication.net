using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobApplication.Models.Domain
{
    public class Technologies
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string TechnologyName { get; set; }

        [Required]
        public string TechLevel { get; set; }

        [ForeignKey("Basic_id")]
        public BasicDetailes BasicDetailes { get; set; }
    }
}
