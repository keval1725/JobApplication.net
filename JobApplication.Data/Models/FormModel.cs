using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.Xml;
using JobApplication.Data.Models.Domain;
using JobApplication.Models.Domain;

namespace JobApplication.Data.Models
{
    public class FormModel
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
