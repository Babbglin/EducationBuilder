using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationLibrary
{
    public interface IEducation
    {
         string Education { get; }
         string Teacher { get; }
         string Students { get; }
         string StudentFeedback { get; }
    }
}
