using GoD.WebApi.Core.Games;
using GoD.WebApi.Core.ViewModels;
using System.Collections.Generic;
using System.Web.Http;

namespace GoD.WebApi.Controllers
{
    public class GamesController : ApiController
    {
        [HttpPost]
        public IHttpActionResult ValidateMoves(IList<MovesViewModel> moves)
        {
            return Ok(GameService.ValidateMoves(moves));
        }
    }
}
