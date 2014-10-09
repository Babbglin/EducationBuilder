using System;
using EducationBuilder.Models;
using EducationLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EducationBuilder = EducationLibrary.EducationBuilder;

namespace EducationBuilderTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestNackademinBuilder()
        {
            //ARRANGE
            IEducation education = new NackademinEducation();
            EducationLibrary.EducationBuilder builder = new NackademinBuilder(education);
            EducationDirector director = new NackademinDirector();

            const string expectedEducation = "Nackademin AB";

           
            //ACT
            IEducation result = director.Build(builder);

            //ASSERT
            Assert.AreEqual(result.Education, expectedEducation);

        }

        [TestMethod]
        public void TestJensenBuilder()
        {
            //ARRANGE
            IEducation education = new JensenEducation();
            EducationLibrary.EducationBuilder builder = new JensenBuilder(education);
            EducationDirector director = new JensenDirector();

            const string expected = "Jensen Education AB";

            //ACT
            IEducation result = director.Build(builder);

            //ASSERT
            Assert.AreEqual(expected, result.Education);
        }

        [TestMethod]
        public void TestIfNackademinGetsCorrectValues()
        {
                //ARRANGE
            IEducation education = new NackademinEducation();
            EducationLibrary.EducationBuilder builder = new NackademinBuilder(education);
            EducationDirector director = new NackademinDirector();
            

           const string expectedEducation = "Nackademin AB";
           const string expectedTeacher = "Mattias Asplund";
           const string expectedFeedback = "Very good";
           const string expectedStudents = "Erik, Sven";
           
           
            //ACT
            IEducation result = director.Build(builder);

            //ASSERT
            Assert.AreEqual(result.Education, expectedEducation);
            Assert.AreEqual(result.Students, expectedStudents);
            Assert.AreEqual(result.Teacher, expectedTeacher);
            Assert.AreEqual(result.StudentFeedback, expectedFeedback);
        }

    }
}
