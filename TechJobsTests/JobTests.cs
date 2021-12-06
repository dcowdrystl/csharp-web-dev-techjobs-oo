using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(10, 10, 0.001);
        }

        [TestMethod]
        public void TestSettingJobId()
        {

            Job job1 = new Job();
            Job job2 = new Job();
            Assert.IsTrue(job1.Id != job2.Id && (job1.Id + 1) == job2.Id);
        }

        /*Job test_job;

        [TestInitialize]
        public void CreateJobObject()
        {
            test_job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        }*/

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.IsTrue(job.Name == "Product tester");
            Assert.IsTrue(job.EmployerName.Value == "ACME");
            Assert.IsTrue(job.EmployerLocation.Value == "Desert");
            Assert.IsTrue(job.JobType.Value == "Quality control");
            Assert.IsTrue(job.JobCoreCompetency.Value == "Persistence");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.IsTrue(!job1.Equals(job2));
        }

        [TestMethod]
        public void ToStringTest()
        {
            Job job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            string output = $"ID: {job.Id}\n Name: {job.Name}\n Employer: {job.EmployerName}\n Location: {job.EmployerLocation}\n " +
                $"Position Type: {job.JobType}\n Core Competency: {job.JobCoreCompetency}";

            Assert.AreEqual(output, job.ToString());
        
        }

        [TestMethod]
        public void ToStringTestWithEmptyValues()
        {
            Job job = new Job("", new Employer(""), new Location(""), new PositionType(""), new CoreCompetency(""));

            string output = $"ID: {job.Id}\n Name: Data not available\n Employer: Data not available\n Location: Data not available\n " +
                $"Position Type: Data not available\n Core Competency: Data not available";

            Assert.AreEqual(output, job.ToString());

        }
    }
}
