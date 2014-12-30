namespace AdbrainReddit.Client.Console
{
    /// <summary>
    /// Starting Class
    /// </summary>
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            IAdbrainRedditClient client = new AdbrainRedditClient();
            client.InsertSportItemsFromRedditService();

        }
    }
}
