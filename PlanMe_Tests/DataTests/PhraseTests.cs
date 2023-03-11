namespace PlanMe_Tests.DataTests
{
    [TestFixture]
    public class PhraseTests
    {
        [Test]
        //Data => PhraseData => GetPhrase()
        public void CheckIfItPhraseIsEmptyOrNull()
        {
            string phrase = PhraseData.GetPhrase();

            // Assert that the enturned phrase is not empty

            Assert.IsFalse(string.IsNullOrEmpty(phrase), "Phrase should not be empty");
        }
    }
}
