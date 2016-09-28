using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebApiEnumsValuesDemo.Extensions;

namespace WebApiEnumsValuesDemo.Controllers
{
    public class HomeController : ApiController
    {
        [HttpGet]
        [Route("accesslevels/all")]
        public IHttpActionResult GetAccessLevels()
        {
            return Ok(EnumExtensions.GetValues<AccessLevel>());
        }

        [HttpGet]
        [Route("addresstypes/all")]
        public IHttpActionResult GetAddressTypes()
        {
            return Ok(EnumExtensions.GetValues<AddressType>());
        }
    }
}
