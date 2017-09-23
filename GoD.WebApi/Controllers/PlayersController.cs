using GoD.WebApi.Core.ViewModels;
using System.Collections.Generic;
using System.Web.Http;

namespace GoD.WebApi.Controllers
{
    public class PlayersController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetData()
        {
            return Ok(new { result = "Oe!" });
        }

        [HttpPost]
        public IHttpActionResult Create([FromBody] IEnumerable<PlayersViewModel> players)
        {

            return Ok(players);
        }
    }
}
