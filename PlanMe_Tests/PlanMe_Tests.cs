using Microsoft.VisualStudio.TestPlatform.TestHost;
using PlanMe.Data;

namespace PlanMe_Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void CheckIfItPhraseIsEmptyOrNull ()
        {
            string phrase = PhraseData.GetPhrase();

            // Assert that the returned phrase is not empty

            Assert.IsFalse(string.IsNullOrEmpty(phrase), "Phrase should not be empty");
        }
    }
}