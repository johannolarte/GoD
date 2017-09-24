using GoD.WebApi.Core;
using GoD.WebApi.Core.ViewModels;
using GoD.WebApi.Persistence;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace GoD.WebApi.Controllers
{
    public class PlayersController : ApiController
    {
        private IUnitOfWork _unitOfWork;

        public PlayersController()
        {
            _unitOfWork = new UnitOfWork();
        }

        [HttpGet]
        public IHttpActionResult GetData()
        {
            return Ok(new { result = "Oe!" });
        }

        [HttpPost]
        public async Task<IHttpActionResult> Create([FromBody] IEnumerable<PlayersViewModel> players)
        {
            await _unitOfWork.Players.CreatePlayers(players);

            return Ok();
        }
    }
}
