using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace JobApplication.Models.Domain
{
    public class Education
    {
        [Key]
        [Required]
        public int EducationId { get; set; }

        [Required(ErrorMessage = "Enter Course Name")]
        [DisplayName("Course Name")]

       
        public string Course { get; set; }

        [Required(ErrorMessage = "Enter a Name of Bord")]
       
   
        public string Board { get; set; }

        [Required(ErrorMessage = "Enter the Percentage")]
        
        [Range(1995, 2022)]
        public int PassYear { get; set; }

        [Required(ErrorMessage = "Enter the Percentage")]
       
        [Range(0, 100)]
        public int Percentage { get; set; }

        [ForeignKey("Basic_id")]
        public BasicDetailes BasicDetailes { get; set; }



    }
}
