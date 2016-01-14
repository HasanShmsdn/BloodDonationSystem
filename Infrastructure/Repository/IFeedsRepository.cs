using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;

namespace Infrastructure.Repository
{
    public interface IFeedsRepository
    {
        void InsertFeeds(Feeds v);

        Feeds[] GetFeedsByUserId(int userId);

        void UpdateFeeds(Feeds v);

        void DeleteFeeds(int v);

        Feeds GetFeeds(int id);

        Feeds[] SelectFeeds(int id, out int total);
    }
}
