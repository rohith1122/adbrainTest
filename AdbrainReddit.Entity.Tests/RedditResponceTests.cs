using Newtonsoft.Json;
using NUnit.Framework;


namespace AdbrainReddit.Entity.Tests
{
    [TestFixture]
    public class RedditResponceTests
    {
        
        

        
      

        [Test]
        public void RedditResponce_Serialization_Test()
        {
            //Assign
            const string jsonIn = "{\"kind\":\"Listing\",\"data\":{\"modhash\":\"\",\"after\":\"t3_2q75az\",\"before\":null,\"children\":null}}";
            var ro = JsonConvert.DeserializeObject<RedditResponse>(jsonIn);

            //Act
            string jsonOut = JsonConvert.SerializeObject(ro);


            //Assert
            Assert.That(jsonIn, Is.EqualTo(jsonOut));
          
        }

        [Test]
        public void RedditResponce_Children_Count_Test()
        {

            const string jsonIn = "{\"kind\":\"Listing\",\"data\":{\"modhash\":\"\",\"children\":[{\"kind\":\"t3\"},{\"kind\":\"t3\"},{\"kind\":\"t3\"},{\"kind\":\"t3\"}],\"after\":\"t3_2q75az\",\"before\":null}}";
            var ro = JsonConvert.DeserializeObject<RedditResponse>(jsonIn);
            Assert.That(ro.MainData.Children.Count, Is.EqualTo(4));

        }


        


    }


    

}
