using System;
using Xunit;

namespace UCHHospital.Tests
{
    public class EmployeeTests
    {
        [Fact]
        public void DrawBloodMethodTest()
        {
            Patient testPatient = new Patient("Fragile Bob");
            Doctor testDoctor = new Doctor("DrTest", 111, "Bloodletting");

            testDoctor.DrawBlood(testPatient);

            Assert.Equal(19, testPatient.BloodLevel);

        }
    }
}
