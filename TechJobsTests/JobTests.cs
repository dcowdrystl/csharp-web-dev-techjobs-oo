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
    }
}
