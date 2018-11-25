using MineRage.DataAccessLayer.Enums;
using MineRage.DataAccessLayer.Models;
using MineRage.DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MineRageApi.Controllers
{
    [RoutePrefix("api/HighScores")]
    public class HighScoresController : ApiController
    {
        IHighScoresRepository _highScoresRepository = null;

        public HighScoresController(IHighScoresRepository highScoresRepository) {
            _highScoresRepository = highScoresRepository;
        }

        [HttpGet]
        [Route("GetByDifficulty")]
        public IEnumerable<HighScore> AddFeedback(Difficulty difficulty)
        {
        return     _highScoresRepository.GetHighScoresByDifficulty(difficulty);
        }
    }
}
