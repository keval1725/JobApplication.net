using JobApplication.Data.Models.Domain;
using JobApplication.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplication.Data.Models
{
    public class UpdateModel
    {
        public BasicDetailes BasicDetailes { get; set; }


        public IQueryable<OptionMaster> RelationStatus { get; set; }
        public IQueryable<OptionMaster> EducationDetailes { get; set; }
        public IQueryable<OptionMaster> AllLangauges { get; set; }

        public IQueryable<OptionMaster> PreferdLocations { get; set; }
        public IQueryable<OptionMaster> TechnologyNames { get; set; }
        public IQueryable<OptionMaster> Departments { get; set; }
        public IQueryable<OptionMaster> Gender { get; set; }

    }
}
