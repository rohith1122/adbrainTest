using System;

namespace AdbrainReddit.Common
{
    public class Conversions 
    {

        public static DateTime UtcToDateTime(long seconds)
        {
            return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(seconds);

        }

    }
}
