using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTest

{
    [TestClass]
    public class JobTests
    {
        Job job;

        [TestInitialize]
        public void CreateJobObject()
        {
            job = new Job("Product tester",
                new Employer("Acme"),
                new Location("Desert"),
                new PositionType("Quality Control"),
                new CoreCompetency("Persistence")
                );
        }

        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();
            Assert.IsTrue(job2.Id == job1.Id + 1);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.IsTrue(job.EmployerName.Value == "Acme");
            Assert.IsTrue(job.EmployerLocation.Value == "Desert");
            Assert.IsTrue(job.JobType.Value == "Quality Control");
            Assert.IsTrue(job.JobCoreCompetency.Value == "Persistence");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job job1 = new Job();
            Job job2 = new Job();
            Assert.IsFalse(job1.Id == job2.Id);
        }

        [TestMethod]

        public void TestToStringForBlankLines()
        {
            Job job1 = new Job();
            Assert.IsTrue(job.ToString().StartsWith("\n"));
            Assert.IsTrue(job.ToString().EndsWith("\n"));
        }

        [TestMethod]

        public void TestForLabelDataNewLines()
        {
            Assert.IsTrue(job.ToString().Contains("\nID: "));
            Assert.IsTrue(job.ToString().Contains("\nName: "));
            Assert.IsTrue(job.ToString().Contains("\nEmployer: "));
            Assert.IsTrue(job.ToString().Contains("\nLocation: "));
            Assert.IsTrue(job.ToString().Contains("\nPosition Type: "));
            Assert.IsTrue(job.ToString().Contains("\nCore Competency: "));
        }

        [TestMethod]

        public void TestForDataNotAvailable() //If a field is empty, the method should add, “Data not available” after the label.
        {
            Assert.IsTrue(job.ToString().Contains("Data not available"));
        }

    }
}
