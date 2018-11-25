using MineRage.DataAccessLayer.Models;

namespace MineRage.DataAccessLayer.Repositories
{
    public interface IFeedbackRepository
    {
        void AddFeedback(Feedback feedback);
    }
}