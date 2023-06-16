using JobApplication.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplication.Data.Models
{
    public class ListModel
    {
      public  List<BasicDetailes> BasicDetailes { get
                ; set; }

        public int pagecount { get; set; }
        

    }
}
