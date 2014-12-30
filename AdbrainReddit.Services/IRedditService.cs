using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdbrainReddit.Entity;
using AdbrainReddit.Services.ViewModels;

namespace AdbrainReddit.Services
{
    public interface IRedditService
    {
        Task<List<AuthorVm>> GetSportsGroupByAuthorAsync(string domain);
        bool InsertRedditResponce(RedditResponse res);
        
    }
}
