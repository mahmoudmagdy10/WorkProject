using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Work.BL.Interface;
using Work.BL.Models;
using Work.DAL.Database;
using Work.DAL.Entity;

namespace Work.BL.Repository
{
    public class ReplyRep : IReplyRep
    {
        #region Fields

        private readonly WorkContext db;
        private readonly IMapper mapper;

        #endregion

        #region Ctor
        public ReplyRep(WorkContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        #endregion

        #region Actions
        public IEnumerable<ReplyVM> Get(Expression<Func<Reply, bool>> filter = null)
        {
            try
            {

                if (filter == null)
                {
                    var data = GetReplys();
                    var model = mapper.Map<IEnumerable<ReplyVM>>(data);
                    return model;
                }
                else
                {
                    var data = db.Reply.Where(filter);
                    var model = mapper.Map<IEnumerable<ReplyVM>>(data);
                    return model;
                }
            }
            catch
            {
                return Enumerable.Empty<ReplyVM>();
            }
        }


        public void Create(ReplyVM obj)
        {
            var model = mapper.Map<Reply>(obj);
            db.Reply.Add(model);
            db.SaveChanges();

        }

        public void Delete(ReplyVM obj)
        {
            var model = mapper.Map<Reply>(obj);
            db.Reply.Remove(model);
            db.SaveChanges();
        }

        public void Edit(ReplyVM obj)
        {
            var model = mapper.Map<Reply>(obj);
            db.Entry(model).State = EntityState.Modified;
            db.SaveChanges();

        }


        public ReplyVM GetById(int id)
        {
            var data = db.Reply.Where(a => a.Id == id).FirstOrDefault();
            var model = mapper.Map<ReplyVM>(data);
            return model;
        }

        #endregion

        #region Refactory Methods
        private IQueryable<Reply> GetReplys()
        {
            return db.Reply.Select(a => a);
        }

        #endregion
    }
}
