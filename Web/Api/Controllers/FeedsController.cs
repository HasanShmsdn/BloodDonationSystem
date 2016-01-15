using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Core.Models;
using Api.Models;
using Api.Models.Mappers;
using Api.Models.Mappers.Imp;
using Infrastructure.Repository.Imp;


namespace Api.Controllers
{
   public class FeedsController : ApiController
    {
        private FeedsRepository _feedsRepository;
        private FeedsMapper _feedsMapper;


        public FeedsController()
        {
            _feedsRepository = new FeedsRepository();
            _feedsMapper = new FeedsMapper();
        }
        [HttpGet]
        // Get api/Feeds
        public IEnumerable<Feeds> Getall([FromUri] int id)
        {
            var feeds = _feedsRepository.GetFeedsByHospId(id);
            return feeds;
        }
        [HttpGet]
        // Get api/Feeds
        public IEnumerable<Feeds> Getall()
        {
            var feeds = _feedsRepository.GetAllFeeds();
            return feeds;
        }
        // GET api/values/5
        [HttpGet]
        public IHttpActionResult Getrequest(int id)
        {
            var n = _feedsRepository.GetFeeds(id);
            if (n == null)
            {
                return NotFound();
            }
            return Ok(n);
        }
        [HttpGet]
        public IHttpActionResult Getnext(int id)
        {
            var total = 0;
            var feeds = _feedsRepository.SelectFeeds(id, out total);
            var data = new { feeds, total };
            return Ok(data);
        }
        [HttpGet]
        // GET api/default1/5
        public IHttpActionResult Getnew(int id)
        {
            Feeds feeds = _feedsRepository.GetFeeds(id);

            if (feeds == null)
            {
                return NotFound();
            }
            return Ok(feeds);
        }
        [HttpPost]
        public void PostFeeds([FromBody]FeedsForm feeds)
        {
            var map = _feedsMapper.Map(feeds);
            _feedsRepository.InsertFeeds(map);
        }
        [HttpDelete]
        public void DeleteFeeds([FromUri] int id)
        {
            _feedsRepository.DeleteFeeds(id);
        }
        [HttpPut]
        public void EditBloodRequest([FromUri] int id, [FromBody] FeedsForm form)
        {

            var map = _feedsMapper.Map(id, form);

            _feedsRepository.UpdateFeeds(map);
        }
        [HttpPost]
        public void PutRegister([FromUri]int id)
        {
            var n = _feedsRepository.GetFeeds(id);
            n.UnitDonor++;
            _feedsRepository.UpdateFeeds(n);
        }
    }
}
