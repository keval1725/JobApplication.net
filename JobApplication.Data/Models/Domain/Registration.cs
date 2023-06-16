using JobApplication.Models.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplication.Data.Models.Domain
{
    public class Registration
    {
         [Key]
         public int Id { get; set; }

         [Required] 
         public string User_Name { get; set; }

         [Required]

         [DataType(DataType.EmailAddress)]

         public string Email { get; set; }


         [DisplayName("Password"),DataType(DataType.Password)]

         [Required]

         public string Password { get; set; }


        [Required]
        [Compare(nameof(Password))]
        [NotMapped]
        public string ConfirmPassword { get; set;}


         [DefaultValue(0)]
         public int IsRole { get; set; }

        


    }
}
