using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdbrainReddit.Entity;
using AdbrainReddit.Services;
using AdbrainReddit.Services.ViewModels;

namespace AdbrainReddit.Api.Tests.Fake
{
    public class FakeReddditService : IRedditService
    {


        private static RedditResponse RedditResponseData()
        {
            return new RedditResponse()
            {

                Kind = "Listing",
                MainData = new MainData()
                {
                    After = "t3_2q8mzi",
                    Before ="",
                    Modhash = "",
                    Children = new List<Child>()
                    {
                        new Child
                        {
                            Data = new Entity.Data()
                            {
                             Domain = "youtube.com",
                             Author = "Author1",
                             Id = "1",
                             Title = "Suh has no class",
                             PermaLink = "http://imgur.com/GoKqwHt.gif"
                            },
                            Kind = "t3"
                            
                        },
                        new Child
                        {
                            Data = new Entity.Data()
                            {
                                Domain = "self.sports",
                                Author = "Author2",
                                Id = "1",
                                Title = "Why would anyone be excited to root for a team playing in something called 'The Developmental League'?",
                                PermaLink = "http://www.reddit.com/r/sports/comments/2qpam1/why_would_anyone_be_excited_to_root_for_a_team/"
                                
                            },
                            Kind = "t3"
                            
                        },
                        new Child
                        {
                            Data = new Entity.Data()
                            {
                                Domain = "youtube.com",
                                Author = "Author3",
                                Id = "2",
                                Title = "How do you score 1 point??",
                                PermaLink = "http://i.imgur.com/4UIpSsX.jpg"

                            },
                            Kind = "t3"
                            
                        },
                        new Child
                        {
                            
                            Data = new Entity.Data()
                            {
                                Domain = "twitter.com",
                                Author = "Author1",
                                Id = "3",
                                Title = "Miami Dolphins RB Lamar Miller's 97-yard TD. 3rd longest run of all-time and longest in the NFL since 2003.",
                                PermaLink = "http://streamable.com/27d"

                            },
                            Kind = "t3"
                        },
                        new Child
                        {
                            Data = new Entity.Data()
                            {
                                Domain = "twitter.com",
                                Author = "Author4",
                                Id = "4",
                                Title = "Textbook slips catch in cricket.",
                                PermaLink = "http://gfycat.com/WhiteEmbarrassedIndianringneckparakeet"
                               
                            },
                            Kind = "t3"
                        }
                    },
                    
                }
              
            
            };
        }
        
        public Task<List<AuthorVm>> GetSportsGroupByAuthorAsync(string domain)
        {


            var authorGroup =
                RedditResponseData()
                    .MainData.Children.Where(e => e.Data.Domain == domain)
                    .ToList()
                    .GroupBy(p => p.Data.Author);

            return Task.FromResult(authorGroup
                    .Select(grp => 
                        new AuthorVm {Name =  grp.Key,Items = grp.Select(x => 
                            new ItemVm
                            {
                                Id = x.Data.Id,
                                CreatedDate = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(x.Data.CreatedUtc).ToLongDateString(),
                                PermaLink = x.Data.PermaLink,
                                Title = x.Data.Title
                            }).ToList()}).ToList());
;
        }
    

        public bool InsertRedditResponce(RedditResponse res)
        {
            return true;
        }
    }
}
