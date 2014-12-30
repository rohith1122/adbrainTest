using AdbrainReddit.Api.Controllers;
using AdbrainReddit.Api.Tests.Fake;
using AdbrainReddit.Services;
using NUnit.Framework;


namespace AdbrainReddit.Api.Tests.Controllers
{
    [TestFixture]
    public class RedditSportsControllerTest
    {
        private IRedditService _service;

        [SetUp]
        public void Initialize() 
         {

            _service = new FakeReddditService();
         } 


        [Test]
        public void RedditSportsController_GroupBy_Author_Test()
        {

            //Arrange

            const string domain = "youtube.com";
            var sut = new RedditSportsController(_service);

            ////Act
            var groupByAuthorResult = sut.Get(domain);

            //Assert
            Assert.That(groupByAuthorResult.Result.Count, Is.EqualTo(2));


        }
    }
}
