using System.Collections.Generic;
using AdbrainReddit.Data;
using AdbrainReddit.Entity;
using AdbrainReddit.Repository;
using NUnit.Framework;

namespace AdbrainReddit.Services.Tests
{
    [TestFixture]
    public class RedditServiceTest
    {
        [Test]
        public void RedditService_Insert_Test()
        {

            
            // Assign
            var ctx = new RedditDataContext();
            IUnitOfWork uow = new UnitOfWork(ctx);
            IRedditService rs = new RedditService(uow);

            var rs1 = new RedditResponse {Kind = "You tube new"};
            var main = new MainData() { Modhash = "Modash", Before = "Before", After = "After" };
            rs1.MainData = main;
            var lst = new List<Child>
            {
                          new Child
                          {
                              Kind = "T1",
                              Data = new Entity.Data
                              {
                                  
                              }
                          },
                          new Child
                          {
                              Kind = "T2",
                              Data = new Entity.Data
                              {
                                  
                              }
                          
                          }
                      };
            main.Children = lst;
         //Act
            bool flag =  rs.InsertRedditResponce(rs1);
            



            //Assert
            Assert.That(flag,Is.True);

        }
    }
}
