using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using AdbrainReddit.Services;
using AdbrainReddit.Services.ViewModels;

namespace AdbrainReddit.Api.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [RoutePrefix("sports")]
    public class RedditSportsController : ApiController
    {
        private readonly IRedditService _service;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="service"></param>
        public RedditSportsController(IRedditService service)
        {
            
            _service = service;

        }

        /// <summary>
        /// welcome get request
        /// </summary>
        /// <returns></returns>
        [Route("")]
        public async Task<string> Get()
        {
            return await Task.Run(() => "Welcome to Reddit api");
        }

        /// <summary>
        /// returns all the items group by author and filter by domain
        /// </summary>
        /// <param name="domain"></param>
        /// <returns></returns>
        [Route("")]
        public async Task<List<AuthorVm>> Get(string domain)
        {
           return await _service.GetSportsGroupByAuthorAsync(domain);
        }

        
    }
}
