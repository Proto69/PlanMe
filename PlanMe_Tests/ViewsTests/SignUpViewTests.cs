namespace PlanMe_Tests.ViewsTests
{
    [TestFixture]
    public class SignUpViewTests
    {
        [Test]
        public void CheckIfReadsAndCreatesUser()
        {
            SignUpView.ReadInfo("Reads", "Read1234", "Read1234");
            User user = UserData.Check("Reads", "Read1234");
            UserData.Delete("Reads");
            Assert.IsNotNull(user, "Does not reads!");
        }
    }
}
