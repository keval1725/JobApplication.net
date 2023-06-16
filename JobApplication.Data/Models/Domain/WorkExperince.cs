using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobApplication.Models.Domain
{
    public class WorkExperince
    {



        [Key]
        public int Work_Id { get; set; }

        [Required(ErrorMessage = "Field can't be empty")]
        public string  Company_name { get; set; }

        [Required(ErrorMessage = "Field can't be empty")]
        public string  DESIGNATION { get; set; }

        [Required(ErrorMessage = "Field can't be empty")]

        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime  From { get; set; }

        [Required(ErrorMessage = "Field can't be empty")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]

        public DateTime  To { get; set; }


        [ForeignKey("Basic_id")]
        public BasicDetailes BasicDetailes { get; set; }



    }
}
