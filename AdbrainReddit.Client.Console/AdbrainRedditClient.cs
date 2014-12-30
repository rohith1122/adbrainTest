using System;
using System.Data.Entity.Infrastructure;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using AdbrainReddit.Data;
using AdbrainReddit.Entity;
using AdbrainReddit.Repository;
using AdbrainReddit.Services;
using log4net;
using Newtonsoft.Json;

namespace AdbrainReddit.Client.Console
{
    /// <summary>
    /// Implementation of the Adbrainreddit client interface
    /// </summary>
    public class AdbrainRedditClient : IAdbrainRedditClient
    {

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// 



        
        private static readonly ILog Log = LogManager.GetLogger(typeof(AdbrainRedditClient));

        private const string BaseUrl = @"http://www.reddit.com/r/sports.json?limit=100";


        public void InsertSportItemsFromRedditService()
        {
            Log.Debug("Retrieving sport items");
            IUnitOfWork uow = new UnitOfWork(new  RedditDataContext());
            IRedditService service = new RedditService(uow);
            using (var client = new HttpClient())
            {
                try
                {
                    var response =  client.GetAsync(BaseUrl).Result;
                    if (!response.IsSuccessStatusCode) return;
                    var res = response.Content.ReadAsAsync<RedditResponse>().Result;
                    service.InsertRedditResponce(res);
                    System.Console.WriteLine(res.MainData.Children.Count);
                }
                catch (Exception ex)
                {
                    Log.Error("Error in GetSportsItems",ex);
                    throw;
                }
               
            }
        }
    }
}
