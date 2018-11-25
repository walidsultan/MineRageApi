using MineRage.DataAccessLayer;
using MineRage.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MineRageApi.Controllers
{
    [RoutePrefix("api/Feedback")]
    public class FeedbackController : ApiController
    {
        IFeedbackRepository _feedbackRepository = null;

        public FeedbackController(IFeedbackRepository feedbackRepository) {
            _feedbackRepository = feedbackRepository;
        }

        [HttpPost]
        [Route("save")]
        public void AddFeedback(Feedback feedback)
        {
            _feedbackRepository.AddFeedback(feedback);
        }
    }
}
