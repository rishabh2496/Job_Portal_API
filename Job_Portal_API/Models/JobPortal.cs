using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Job_Portal_API.Models
{
    public class JobPortal
    {
        //Primary Key
        public int Id { get; set; }

        //Name of the employee Name
        public string Employer_Name { get; set; }

        //Advertisement title
        public string Job_Title { get; set; }

        //Advertisement description
        public string Job_Description { get; set; }

        //Holds salary information.
        public string SalaryRange { get; set; }

    }
}
