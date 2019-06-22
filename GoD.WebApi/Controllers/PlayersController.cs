using GoD.WebApi.Core;
using GoD.WebApi.Core.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace GoD.WebApi.Controllers
{
    public class PlayersController : ApiController
    {
        private readonly IUnitOfWork _unitOfWork;

        public PlayersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetPlayers()
        {
            return Ok(await _unitOfWork.Players.GetPlayers());
        }

        [HttpPost]
        public async Task<IHttpActionResult> CreatePlayers([FromBody] IEnumerable<PlayersViewModel> players)
        {
            _unitOfWork.Players.CreatePlayers(players);

            await _unitOfWork.CompleteTaskAsync();

            return Ok();
        }
    }
}
