using JobApplication.Data;
using JobApplication.Infrastructure.InterFace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApplication.Infrastructure.Implementation
{
    public class JobApplicationRepositry :IJobApplicationRepositry
    {

        private readonly JobDbContext _context;
        public JobApplicationRepositry(JobDbContext context)
        {
            _context = context;
        }


    }
}
