using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplication.Data.Models.Domain
{
    public class OptionMaster
    {
        [Key]
        public int OptionMasterId { get; set; }
        [Required]
        public string OptionMasterFieldName { get; set; }

        [ForeignKey("SelectMasterId")]
        public int SelectMasterId { get; set; }
        public SelectMaster SelectMaster { get; set; }
    }   
}
