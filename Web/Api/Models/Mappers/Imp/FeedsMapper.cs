using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Core.Models;

namespace Api.Models.Mappers.Imp
{
    public class FeedsMapper
    {
        public Feeds Map(FeedsForm form)
        {
            var newRequest = new Feeds();
            newRequest.UnitRequired = form.UnitRequired;
            newRequest.UnitType = form.UnitType;
            newRequest.Date = DateTime.Now;
            newRequest.HospId = form.HospId;
            return newRequest;
        }
        public Feeds Map(int n, FeedsForm form)
        {
            var newRequest = new Feeds();
            newRequest.BloodRequestId = n;
            newRequest.UnitRequired = form.UnitRequired;
            newRequest.UnitType = form.UnitType;
            newRequest.Date = DateTime.Now;
            newRequest.HospId = form.HospId;
            newRequest.UnitDonor = form.UnitDonor;
            return newRequest;
        }
    }
}