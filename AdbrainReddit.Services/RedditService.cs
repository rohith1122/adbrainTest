using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdbrainReddit.Common;
using AdbrainReddit.Entity;
using AdbrainReddit.Repository;
using AdbrainReddit.Services.ViewModels;

namespace AdbrainReddit.Services
{
    public class RedditService :IRedditService,IClear
    {
        private readonly IUnitOfWork _uow;


        public RedditService(IUnitOfWork uow)
        {
            _uow = uow;
        }




        /// <summary>
        /// Get all sports group by author
        /// </summary>
        /// <param name="domain"></param>
        /// <returns></returns>
        public async Task<List<AuthorVm>>  GetSportsGroupByAuthorAsync(string domain)
        {

            var results =
                await _uow.Repository<Data>().Query().Filter(e => e.Domain == domain).GetAsync(); 
                return results.ToList().GroupBy(p => p.Author)
                    .Select(grp => 
                        new AuthorVm {Name =  grp.Key,Items = grp.Select(x => 
                            new ItemVm
                            {
                                Id = x.Id,
                                CreatedDate  = Conversions.UtcToDateTime(x.CreatedUtc).ToLongDateString(),
                                PermaLink = x.PermaLink,
                                Title = x.Title,
                                Domain = x.Domain
                            }).ToList()}).ToList();
        }
        /// <summary>
        /// clear all the existing records in database  and insert new records 
        /// </summary>
        /// <param name="res"></param>
        /// <returns></returns>
        public bool InsertRedditResponce(RedditResponse res)
        {
            try
            {
                ClearTables();
                res.UId = 1;
                res.State = ObjectState.Added;
                res.MainData.UId = res.UId;
                res.MainData.State = ObjectState.Added;
                var i = 1;
                foreach (var child in res.MainData.Children)
                {
                    child.State = ObjectState.Added;
                    child.MainDataId = res.UId;
                    int uid = i++;
                    child.UId = uid;
                    child.Data.UId = uid;
                    child.Data.State = ObjectState.Added;
                }
                _uow.Repository<RedditResponse>().Insert(res);
                _uow.Save();
                return true;

            }
            catch (Exception ex)
            {
                
                throw ex;
                
                
            }
        }
        /// <summary>
        /// delete all records where id =1
        /// </summary>
        /// <returns></returns>
        public   void ClearTables()
        {
            var obj = _uow.Repository<RedditResponse>().Query().Filter(e => e.UId == 1).Get();
            if (obj.Any())
            {
                _uow.Repository<RedditResponse>().Delete(1);
                _uow.Save();
            }
        }
    }
}
