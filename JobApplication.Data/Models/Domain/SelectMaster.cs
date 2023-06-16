using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplication.Data.Models.Domain
{
    public class SelectMaster
    {

        [Key]
        public int SelectMasterId { get; set; }
        [Required]
        public string MasterFieldName { get; set; }
        public ICollection<OptionMaster> optionMasters { get; set; }
    }
}
