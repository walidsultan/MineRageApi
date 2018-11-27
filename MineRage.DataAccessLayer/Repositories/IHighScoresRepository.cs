using MineRage.DataAccessLayer.Enums;
using MineRage.DataAccessLayer.Models;
using System.Collections.Generic;

namespace MineRage.DataAccessLayer.Repositories
{
    public interface IHighScoresRepository
    {
        IEnumerable<HighScore> GetHighScoresByDifficulty(Difficulty difficulty);
        void SaveHighscore(HighScore highscore);
    }
}