using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobApplication.Models.Domain
{
    public class Prefrences
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Select Prefered Location")]
        [StringLength(50)]
        public string PreferedLocation { get; set; }
        [Required(ErrorMessage = "Please Enter Notice Period Time")]
        [StringLength(100)]
        public string NoticePeriod { get; set; }
        [Required(ErrorMessage = "Please Enter Expected CTC")]
        [Range(240000, int.MaxValue)]
        public long ExpectedCTC { get; set; }
        [Required(ErrorMessage = "Please Enter Current CTC")]
        [Range(240000, int.MaxValue)]
        public long CurrentCTC { get; set; }

        [Required(ErrorMessage = "Please Choose Department")]
        public string Department { get; set; }

        [ForeignKey("Basic_id")]
        public BasicDetailes BasicDetailes { get; set; }

    }
}
