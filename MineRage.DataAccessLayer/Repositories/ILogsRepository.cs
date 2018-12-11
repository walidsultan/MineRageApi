using MineRage.DataAccessLayer.Models;

namespace MineRage.DataAccessLayer.Repositories
{
    public interface ILogsRepository
    {
        void SaveLog(Log log);
    }
}