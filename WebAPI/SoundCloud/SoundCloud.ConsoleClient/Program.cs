namespace SoundCloud.ConsoleClient
{
    using SoundCoud.Data;
    using SoundCoud.Data.Repositories;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
            var db = new SoundCloudData();
            db.Artists.SearchFor( a => a.Name == null);
        }
    }
}
