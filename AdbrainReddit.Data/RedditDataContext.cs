using System.Data.Entity;
using AdbrainReddit.Data.Mapping;
using AdbrainReddit.Repository;

namespace AdbrainReddit.Data
{



    public partial class RedditDataContext : DbContextBase
    {
        public RedditDataContext()
            : base("Name=RedditCon")
        {
            Database.SetInitializer<RedditDataContext>(null);
            Configuration.ProxyCreationEnabled = false;
        }
      

        

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ChildMap());
            modelBuilder.Configurations.Add(new DataMap());
            modelBuilder.Configurations.Add(new MainDataMap());
          //  modelBuilder.Configurations.Add(new MediaMap());
          //  modelBuilder.Configurations.Add(new MediaEmbedMap());
           // modelBuilder.Configurations.Add(new SecureMediaMap());
          //  modelBuilder.Configurations.Add(new SecureMediaEmbedMap());
          //  modelBuilder.Configurations.Add(new MediaOembedMap());
           // modelBuilder.Configurations.Add(new SecureMediaOembedMap());
            modelBuilder.Configurations.Add(new RedditResponseMap());

        }

    }

    
    
}
