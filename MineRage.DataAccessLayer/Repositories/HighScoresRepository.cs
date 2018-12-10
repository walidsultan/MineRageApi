using MineRage.DataAccessLayer.Enums;
using MineRage.DataAccessLayer.Models;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Web;

namespace MineRage.DataAccessLayer.Repositories
{
    public class HighScoresRepository : IHighScoresRepository
    {
        public IEnumerable<HighScore> GetHighScoresByDifficulty(Difficulty difficulty)
        {
            using (var context = new MineRageDBContext())
            {
                return context.HighScores.Where(x => x.Difficulty == (int)difficulty && x.IsSignedIn).GroupBy(x => x.Name).Select(x =>
                  x.OrderBy(z => z.Time).FirstOrDefault()).OrderBy(x => x.Time).ToList();
            }
        }

        public void SaveHighscore(HighScore highscore)
        {
            using (var context = new MineRageDBContext())
            {
                context.HighScores.Add(highscore);
                context.SaveChanges();
            }
        }

   
    }
}
