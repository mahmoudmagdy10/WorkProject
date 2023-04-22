using AutoMapper;
using Work.BL.Interface;
using Work.BL.Models;
using Work.DAL.Database;
using Work.DAL.Entity;

namespace Work.BL.Repository
{
    public class ChatRep : IChatRep
    {
        private readonly WorkContext db;
        private readonly IMapper mapper;

        public ChatRep(WorkContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }
        public void Create(ChatVM obj)
        {
            var model = mapper.Map<Chat>(obj);
            db.Chat.Add(model);
            db.SaveChanges();
        }

        public void Delete(ChatVM obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ChatVM> Get()
        {
            var data = GetChat();
            var model = mapper.Map<IEnumerable<ChatVM>>(data);
            return model;
        }

        private IEnumerable<Chat> GetChat()
        {
            return db.Chat.Select(a => a);
        }
    }
}
