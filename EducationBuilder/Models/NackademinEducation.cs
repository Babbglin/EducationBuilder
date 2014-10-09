using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EducationLibrary;

namespace EducationBuilder.Models
{
    public class NackademinEducation : IEducation
    {
        public string Education
        {
            get
            {
                return "Nackademin AB";
            }
        }


        public string Teacher
        {
            get {return "Mattias Asplund"; }
        }

        public string Students
        {
            get { return "Erik, Sven"; }
        }

        public string StudentFeedback
        {
            get { return "Very good"; }
        }
    }
}
