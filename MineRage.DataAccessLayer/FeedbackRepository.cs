using MineRage.DataAccessLayer.Models;

namespace MineRage.DataAccessLayer
{
    public class FeedbackRepository:IFeedbackRepository
    {
        public void AddFeedback(Feedback feedback ) {
            using (var context = new MineRageDBContext()) {
                context.Feedback.Add(feedback);
                context.SaveChanges();
            }
        }
    }
}
