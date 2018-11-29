using MineRage.DataAccessLayer.Enums;
using MineRage.DataAccessLayer.Models;
using MineRage.DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace MineRageApi.Controllers
{
    [RoutePrefix("api/HighScores")]
    public class HighScoresController : ApiController
    {
        IHighScoresRepository _highScoresRepository = null;

        public HighScoresController(IHighScoresRepository highScoresRepository)
        {
            _highScoresRepository = highScoresRepository;
        }

        [HttpGet]
        [Route("GetByDifficulty")]
        public IEnumerable<HighScore> GetHighscores(Difficulty difficulty)
        {
            return _highScoresRepository.GetHighScoresByDifficulty(difficulty);
        }

        [HttpPost]
        [Route("SaveHighscore")]
        public void SaveHighscore(HighScore highscore)
        {
            highscore.IpAddress = GetIPAddress();
            highscore.CreatedDate = DateTime.Now;
            _highScoresRepository.SaveHighscore(highscore);
        }

        protected string GetIPAddress()
        {
            HttpContext context = HttpContext.Current;
            string ipAddress = context.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

            if (!string.IsNullOrEmpty(ipAddress))
            {
                string[] addresses = ipAddress.Split(',');
                if (addresses.Length != 0)
                {
                    return addresses[0];
                }
            }

            return context.Request.ServerVariables["REMOTE_ADDR"];
        }
    }
}
