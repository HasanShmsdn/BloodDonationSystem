using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Core.Models;

namespace Infrastructure.Repository.Imp
{
    public class FeedsRepository: DbRepository, IFeedsRepository
    {
        public void InsertFeeds(Feeds feeds)
        {
            using (var cnn = OpenConnection())
            {
                var id = cnn.Insert(feeds);
            }
        }

        public Feeds[] GetFeedsByUserId(int userId)
        {
            var tab = cnn.GetList<Feeds>().Where(x => x.UserId == userId).OrderByDescending(x => x.Date).ToArray();
            return tab;
        }

        public Feeds[] GetAllFeeds()
        {
            var query = 
                "Select ";
            using (var cnn = OpenConnection())
            {
                return cnn.Query(query).Select(x => new Feeds()
                {
                    HospId = x.HospId,
                    Date = x.Date,
                    Id = x.BID,
                    BloodType = x.BloodType,
                }).ToArray();
            }
        }

        public void UpdateFeeds(Feeds v)
        {
            throw new NotImplementedException();
        }

        public void DeleteFeeds(int v)
        {
            throw new NotImplementedException();
        }

        public Feeds GetFeeds(int id)
        {
            throw new NotImplementedException();
        }

        public Feeds[] SelectFeeds(int id, out int total)
        {
            throw new NotImplementedException();
        }
    }
}
