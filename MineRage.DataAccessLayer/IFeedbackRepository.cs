using MineRage.DataAccessLayer.Models;

namespace MineRage.DataAccessLayer
{
    public interface IFeedbackRepository
    {
        void AddFeedback(Feedback feedback);
    }
}