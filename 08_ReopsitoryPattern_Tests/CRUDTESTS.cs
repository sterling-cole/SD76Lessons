using _07_RepositoryPattern_Repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _08_ReopsitoryPattern_Tests
{
    [TestClass]
    public class CRUDTests
    {
        //Fields(private, variables for use with class only)
        private StreamingContent_Repo _repo;
        private StreamingContent _content;

        [TestInitialize]
        public void Seed()
        {
            _repo = new StreamingContent_Repo();
            StreamingContent theRoom = new StreamingContent(
                "The Room",
                "Everyone betrays Johnny and he's fed up with this world",
                Maturity.R,
                5,
                GenreType.Romance
                );
            StreamingContent spaceballs = new StreamingContent(
                "Spaceballs",
                "fun in space",
                Maturity.PG,
                5,
                GenreType.Comedy
                );
            _repo.AddContentToDirectory(theRoom);
            _repo.AddContentToDirectory(spaceballs);

            _content = new StreamingContent(
                "Groundhog Day",
                "Bill Murray gets caught in a time loop for no reason",
                Maturity.PG,
                5,
                GenreType.Drama
                );
            _repo.AddContentToDirectory(_content);
        }

        [TestMethod]
        public void AddTest()
        {

            // AAA Testing Pattern
            // Arrange
            // Act
            // Assert

            // Arrange
            StreamingContent content = new StreamingContent(
                "Galaxy Quest",
                "Sci Fi actors go on real Sci Fi adventure",
                Maturity.PG13,
                5,
                GenreType.Comedy
                );

            // Act
            bool wasAdded = _repo.AddContentToDirectory(content);

            Console.WriteLine(_repo.Count);
            Console.WriteLine(wasAdded);
            Console.WriteLine(content.Title);

            // Assert
            Assert.IsTrue(wasAdded);

        }



        [TestMethod]
        public void FindByTitle_ShouldGetCorrectContent()
        {
            //Arrange
            // Act
            StreamingContent searchResult = _repo.GetContentByTitle("Groundhog Day");
            // Assert
            Assert.AreEqual(searchResult, _content);
        }

        [TestMethod]
        public void GetFamilyFriendly_ShouldOnlyGetFamilyFriendly()
        {
            // Arrange
            // Act
            List<StreamingContent> familyFriendly = _repo.GetFamilyFriendlyContent();
            foreach (StreamingContent content in familyFriendly)
            {
                Assert.IsTrue(content.IsFamilyFriendly);
            }
            Assert.AreEqual(2, familyFriendly.Count);
        }

        [TestMethod]
        public void UpdateContent_ShouldUpdate()
        {
            StreamingContent newContent = new StreamingContent(
                "Spaceballs",
                "Funny movie about star balls",
                Maturity.PG13,
                5,
                GenreType.SciFiComedy
                );
           bool wasUpdated =  _repo.UpdateExistingContent("Spaceballs", newContent);

            Assert.IsTrue(wasUpdated);
            StreamingContent updatedContent = _repo.GetContentByTitle("Spaceballs");
            GenreType expected = GenreType.SciFiComedy;
            GenreType actual = updatedContent.GenreType;
            Assert.AreEqual(expected, actual);
            Console.WriteLine(updatedContent.Description);
        }

        [TestMethod]
        public void DeleteContent_ShouldDelete()
        {
            bool wasRemoved = _repo.DeleteContent("the room");
            Assert.IsTrue(wasRemoved);

        }
    }
}
