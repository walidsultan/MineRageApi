using MineRage.DataAccessLayer.Enums;
using MineRage.DataAccessLayer.Models;
using System.Collections.Generic;
using System.Linq;

namespace MineRage.DataAccessLayer.Repositories
{
    public class HighScoresRepository : IHighScoresRepository
    {
        public IEnumerable<HighScore> GetHighScoresByDifficulty(Difficulty difficulty)
        {
            using (var context = new MineRageDBContext())
            {
              return  context.HighScores.Where(x => x.Difficulty == (int)difficulty).OrderBy(x => x.Time).ToList();
            }
        }
    }
}
