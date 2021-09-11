using NouApi.Models;

namespace NouApi.Data
{
    public interface IMessageRepo
    {
        bool SaveChanges();
        Message GetLatestMessage();
        void CreateMessage(Message message);
    }
}
