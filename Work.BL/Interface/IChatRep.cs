using Work.BL.Models;
using Work.DAL.Entity;

namespace Work.BL.Interface
{
    public interface IChatRep
    {
        IEnumerable<ChatVM> Get();
        void Create(ChatVM obj);
        void Delete(ChatVM obj);
    }
}
