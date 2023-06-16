using JobApplication.Data.Models.Domain;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobApplication.Models.Domain
{
    public class BasicDetailes
    {
        [Key]
        public int Basic_id { get; set; }

        [Required(ErrorMessage = "Field can't be empty")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        public string FIRST_NAME { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        public string LAST_NAME { get; set;}    
        [Required(ErrorMessage = "Field can't be empty")]
        public string DESIGNATION { get; set; }

        [Required(ErrorMessage = "Field can't be empty")]
        public string ADDRESS1 { get; set; }

        [Required(ErrorMessage = "Field can't be empty")]

        public string ADDRESS2 { get; set; }

        [Required(ErrorMessage = "Field can't be empty")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Field can't be empty")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "PhoneNumber is not valid")]

        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Field can't be empty")]
        
        public string Gender { get; set; }

        [Required(ErrorMessage = "Field can't be empty")]

        public string State { get; set; }

        [Required(ErrorMessage = "Field can't be empty")]

        public string City { get; set; }

        [Required(ErrorMessage = "Field can't be empty")]

        [DataType(DataType.PostalCode, ErrorMessage = "Postcode is Not A Valid")]
        public string ZipCode { get; set; }

        [DefaultValue(0)]
        public int IsDeleted { get; set; }


        [Required(ErrorMessage = "Field can't be empty")]
        public string RELATIONSHIP_STATUS { get; set; }

        [Required(ErrorMessage = "Field can't be empty")]

        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DOB { get; set;}

        public List<Education> Educations { get; set; }
        public List<Langauge> Langauges { get; set; }
        public List<Prefrences> Prefrencess { get; set; }
        public List<Technologies> Technologiess { get; set; }
        public List<WorkExperince> WorkExperinces { get; set; }
        public List<Refrence> Refrences { get; set; }

        [ForeignKey("User_id")]
        public int? UserId { get; set; }
       
    }
}
