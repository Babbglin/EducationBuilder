﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationLibrary
{
    public class JensenBuilder:EducationBuilder
    {
        private IEducation educationInProgress;

        public JensenBuilder(IEducation education)
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
