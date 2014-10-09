using EducationBuilder.Models;
using EducationLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            IEducation education = new NackademinEducation();
            EducationLibrary.EducationBuilder builder = new NackademinBuilder(education);
            EducationDirector director = new NackademinDirector();

            IEducation result = director.Build(builder);

            Console.ReadLine();
        }
    }
}
