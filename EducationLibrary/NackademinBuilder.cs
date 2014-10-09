using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace EducationLibrary
{
   public class NackademinBuilder:EducationBuilder
    {
        private IEducation educationInProgress;

        public NackademinBuilder(IEducation education)
        {
            educationInProgress = education;
        }

        public override void AssignTeacher()
        {
            Console.WriteLine("Assigning teacher");
        }

        public override void InviteStudents()
        {
            Console.WriteLine("Inviting students");
        }

        public override void ProcessStudentFeedback()
        {
            Console.WriteLine("Processing student feedback");
        }

        public override IEducation Education
        {
            get { return educationInProgress; }
        }
    }
}
