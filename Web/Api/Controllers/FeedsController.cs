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
    [RoutePrefix("api/feeds")]
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
        [Route("FeedsByHospId/{id}")]
        // Get api/Feeds
        public IEnumerable<Feeds> FeedsByHospId([FromUri] int id)
        {
            var feeds = _feedsRepository.GetFeedsByHospId(id);
            return feeds;
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<Feeds> Getall()
        {
            var feeds = _feedsRepository.GetAllFeeds();
            return feeds;
        }
        // GET api/values/5
        [HttpGet]
        [Route("{id}")]
        public IHttpActionResult Get(int id)
        {
            var n = _feedsRepository.GetFeeds(id);
            if (n == null)
            {
                return NotFound();
            }
            return Ok(n);
        }

        //[HttpGet]
        //[ActionName("GetNext")]
        //public IHttpActionResult Getnext(int id)
        //{
        //    var total = 0;
        //    var feeds = _feedsRepository.SelectFeeds(id, out total);
        //    var data = new { feeds, total };
        //    return Ok(data);
        //}

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

        //[HttpPost]
        //[ActionName("Register")]
        //public void PutRegister([FromUri]int id)
        //{
        //    var n = _feedsRepository.GetFeeds(id);
        //    n.UnitDonor++;
        //    _feedsRepository.UpdateFeeds(n);
        //}
    }
}
