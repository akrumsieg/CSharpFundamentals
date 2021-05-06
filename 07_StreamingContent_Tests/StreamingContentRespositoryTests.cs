using _07_StreamingContent_Repository;
using _07_StreamingContent_Repository.Content;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _07_StreamingContent_Tests
{
    [TestClass]
    public class StreamingContentRespositoryTests
    {
        [TestMethod]
        public void AddToDirectory_ShouldGetCorrectBoolean()
        {
            //AAA - arrange, act, assert
            //ARRANGE
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repository = new StreamingContentRepository();

            //ACT
            bool addResult = repository.AddContentToDirectory(content);

            //ASSERT
            Assert.IsTrue(addResult);
        }

        [TestMethod]
        public void GetDirectory_ShouldReturnCorrectCollection()
        {
            //arrange
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repository = new StreamingContentRepository();
            repository.AddContentToDirectory(content);

            //act
            List<StreamingContent> directory = repository.GetContents();

            //assert
            bool directoryHasContent = directory.Contains(content);
            Assert.IsTrue(directoryHasContent);
        }

        //variables for arrange method
        private StreamingContent _content;
        private StreamingContentRepository _repo;

        //arrange method - so we don't have to keep writing the same arrange lines
        [TestInitialize]
        public void Arrange()
        {
            _content = new StreamingContent("Back to the Future", "A high school student named Marty gets accidentally sent back in time 30 years.", 4.4, GenreType.SciFi, MaturityRating.PG);
            _repo = new StreamingContentRepository();
            _repo.AddContentToDirectory(_content);
        }

        [TestMethod]
        public void CheckMovieRunTime()
        {
            //create movie type using full constructor with inherited base
            Movie joe = new Movie("Joe Dirt", "The story about a mullet and his meteor", 3.2, GenreType.Comedy, MaturityRating.PG_13, 112);
            //creating a list to replicate our repo
            List<StreamingContent> miniRepo = new List<StreamingContent>();
            miniRepo.Add(joe);

            foreach (Movie content in miniRepo)
            {
                Console.WriteLine(content.RunTime); ;
            }
            //searching for StreamingContent makes run time unavailable without casting
            foreach (StreamingContent content in miniRepo)
            {
                //finding movie types
                if (content is Movie)
                {
                    //setting content as Movie to access Movie exclusive properties
                    Console.WriteLine(((Movie)content).RunTime);
                }
            }
        }

        [TestMethod]
        public void GetContentByTitle_ShouldReturnCorrectContent()
        {
            //arrange (already done in Arrange method)

            //act
            StreamingContent searchResult = _repo.GetContentByTitle("back to THE Future");

            //assert
            Assert.AreEqual(_content, searchResult);
        }

        [TestMethod]
        public void UpdateExistingContent_ShouldReturnUpdatedValue()
        {
            //arrange, already done
            //act
            _repo.UpdateExistingContent("Back to the Future",
                new StreamingContent(
                    "Back to the Future 2",
                    "Marty goes into the future 30 years.",
                    4.0,
                    GenreType.SciFi,
                    MaturityRating.PG_13));

            //assert
            Assert.AreEqual(_content.Title, "Back to the Future 2");
        }

        [TestMethod]
        public void DeleteExistingContent_ShouldReturnTrue()
        {
            bool wasDeleted = _repo.DeleteExistingContent("Back to the FUTURE");
            Assert.IsTrue(wasDeleted);
        }
    }
}
