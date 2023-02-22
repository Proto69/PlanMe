using PlanMe;
using PlanMe.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanMe_Tests.ViewsTests
{
    [TestFixture]
    public class SignUpViewTests
    {
        [Test]
        public void CheckIfReadsAndCreatesUser()
        {
            SignUpView.ReadInfo("Reads", "Read12", "Read12");
            User user = UserData.Check("Reads", "Read12");
            UserData.Delete("Reads");
            Assert.IsNotNull(user, "Does not reads!");
        }
    }
}
