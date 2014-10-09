using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EducationLibrary;

namespace EducationBuilder.Models
{
    public class JensenEducation : IEducation
    {
        public string Education
        {
            get
            {
                return "Jensen Education AB";

            }
        }


        public string Teacher
        {
            get { return "Unknown"; }
        }

        public string Students
        {
            get { return "None"; }
        }

        public string StudentFeedback
        {
            get {return "Very bad"; }
        }
    }
}
