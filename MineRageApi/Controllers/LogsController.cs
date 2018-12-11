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
    [RoutePrefix("api/Logs")]
    public class LogsController : ApiController
    {
        ILogsRepository _logsRepository = null;

        public LogsController(ILogsRepository logsRepository)
        {
            _logsRepository = logsRepository;
        }

        [HttpPost]
        [Route("SaveLog")]
        public void SaveLog(Log log)
        {
            log.IpAddress = GetIPAddress();
            log.CreatedDate = DateTime.Now;
            _logsRepository.SaveLog(log);
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
