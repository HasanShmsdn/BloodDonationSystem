using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Core.Models;
using Dapper;

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

        public Feeds[] GetFeedsByHospId(int hospId)
        {

            using (var cnn = OpenConnection())
            {
                var tab = cnn.GetList<Feeds> ().Where(x => x.HospId == hospId).OrderByDescending(x => x.Date).ToArray();
                return tab;

            }
        }

        public Feeds[] GetAllFeeds()
        {
            var query = 
                "Select r.Id as RID, b.HospId as HsopId,b.UnitType as UnitType, b.Date as Date, b.UnitRequired as UnitRequired, b.UnitOffered as UnitOffered, b.UnitDonor as UnitDonor, u.HospName from Feeds b inner join Hosp u on u.Id = b.HospId Order by Date Desc   ";
            using (var cnn = OpenConnection())
            {
                return cnn.Query(query).Select(x => new Feeds()
                {
                    HospId = x.HospId,
                    Date = x.Date,
                    BloodRequestId = x.RID,
                    UnitType = x.UType,
                    UnitDonor = x.UnitDonor,
                    UnitOffered = x.UnitOffered,
                    UnitRequired = x.UnitRequired, 
                }).ToArray();
            }
        }

        public void UpdateFeeds(Feeds feeds)
        {
            using (var cnn = OpenConnection())
            {
                cnn.Update(feeds);
            }
        }

        public void DeleteFeeds(int val)
        {
            using (var cnn = OpenConnection())
            {
                cnn.Delete<Feeds>(val);
            }
        }

        public Feeds GetFeeds(int id)
        {
            using (var cnn = OpenConnection())
            {
                var tab = cnn.Get<Feeds>(id);
                return tab;
            }
        }

        public Feeds[] SelectFeeds(int id, out int total)
        {
            using (var cnn = OpenConnection())
            {
                var tab = cnn.GetList<Feeds>().OrderByDescending(x => x.Date).ToArray();
                var totalcount = tab.Count();
                var currentpage = id;
                const int pagesize = 3;
                total = (int)Math.Ceiling((double)totalcount / pagesize);
                var pagetab = tab.Skip((currentpage - 1) * pagesize)
                                    .Take(pagesize)
                                    .ToArray();
                return pagetab;
            }
        }
    }
}
