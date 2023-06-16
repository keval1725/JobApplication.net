using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobApplication.Models.Domain
{
    public class Refrence
    {

        [Key]

        public int RefrenceId { get; set; }
        [Required(ErrorMessage = "Please Enter a Referenced Person Name")]
        [StringLength(50)]
        public string ReferencePersonName { get; set; }

        [Required(ErrorMessage = "Please Enter a Referenced Contact Name")]
        [DisplayName("Refence person Contact ")]
        [DataType(DataType.PhoneNumber)]
        public long ReferencePersonContact { get; set; }
        [Required(ErrorMessage = "Please Enter a Your Relation With Referenced Person")]
        [StringLength(50)]
        public string RefrencePersonRelation { get; set; }
        [ForeignKey("Basic_id")]
        public BasicDetailes BasicDetailes { get; set; }
    }
}
