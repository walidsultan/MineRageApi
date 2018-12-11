using MineRage.DataAccessLayer.Enums;
using MineRage.DataAccessLayer.Models;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Web;

namespace MineRage.DataAccessLayer.Repositories
{
    public class LogsRepository : ILogsRepository
    {
        public void SaveLog(Log log)
        {
            using (var context = new MineRageDBContext())
            {
                context.Logs.Add(log);
                context.SaveChanges();
            }
        }

   
    }
}
