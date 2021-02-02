using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        Job test1;
        Job test2;
        Job test3;
        Job testObj1;
        Job testObj2;
        

        [TestInitialize]
        public void CreateJobObject()
        {
            test1 = new Job();
            test2 = new Job();
            test3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            testObj1 = new Job();
            testObj2 = new Job();
            
        }

        [TestMethod]
        public void TestSettingJobId()
        {
            Assert.IsFalse( test1.Id == test2.Id);
            Assert.AreEqual(test1.Id + 1, test2.Id);
        }
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual("Product tester", test3.Name);
            Assert.AreEqual("ACME", test3.EmployerName.Value);
            Assert.AreEqual("Desert", test3.EmployerLocation.Value);
            Assert.AreEqual("Quality control", test3.JobType.Value);
            Assert.AreEqual("Persistence", test3.JobCoreCompetency.Value);
        }
        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.IsFalse(testObj1.Equals(testObj2));
        }
       
        [TestMethod]
        public void Tostring()
        {
            string expected = "\n"+"Id: " + $"{test3.Id}" + "\n" 
                                +"Name: "+ $"{test3.Name}"+"\n"
                                + "EmployerName: " +$"{test3.EmployerName}" +"\n"
                                + "EmployerLocation: " +$"{ test3.EmployerLocation}" + "\n"
                                + "JobType: " + $"{ test3.JobType}" + "\n"
                                + "JobCoreCompetency: " + $"{ test3.JobCoreCompetency}"+"\n";

            Assert.AreEqual(expected, test3.ToString());
        }

    }
}
