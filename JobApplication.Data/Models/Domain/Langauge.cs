using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobApplication.Models.Domain
{
    public class Langauge
    {

        [Key]
        public int Langauge_Id { get; set; }

      
        public string? langauge { get; set; }


        [DefaultValue("No")]
        public string? Read { get; set; }
        
        [DefaultValue("No")]
        public string? Write { get; set; }

        [DefaultValue("No")]
        public string? Speak { get; set; }

        [ForeignKey("Basic_id")]
        public BasicDetailes BasicDetailes { get; set; }
    }
}
