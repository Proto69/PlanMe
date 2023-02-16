using PlanMe.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            // Assert that the returned phrase is not empty

            Assert.IsFalse(string.IsNullOrEmpty(phrase), "Phrase should not be empty");
        }
    }
}
