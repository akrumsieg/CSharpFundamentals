using _07_StreamingContent_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _07_StreamingContent_Tests
{
    [TestClass]
    public class StreamingContentPOCOTests
    {
        [DataTestMethod] //DATA TEST METHOD
        [DataRow(MaturityRating.G, true)] //arguments for the test
        [DataRow(MaturityRating.PG, true)]
        [DataRow(MaturityRating.R, false)]
        public void SetMaturityRating_ShouldGetCorrectIsFamilyFriendly(MaturityRating rating, bool expectedIsFamilyFriendly)
        {
            StreamingContent newContent = new StreamingContent("Back to the Future", "A high school student named Marty gets accidentally sent back in time 30 years.", 4.4, GenreType.SciFi, rating);

            bool actual = newContent.IsFamilyFriendly;

            Assert.AreEqual(actual, expectedIsFamilyFriendly);
        }
    }
}
