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
            /*int id = (job1.Id + 1);
            Assert.IsTrue(id == job2.Id);*/
        }
    }
}
