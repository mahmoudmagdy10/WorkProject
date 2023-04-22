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
    public class PostRep : IPostRep
    {
        #region Fields

        private readonly WorkContext db;
        private readonly IMapper mapper;
        private readonly IUserRep userRep;

        #endregion

        #region Ctor
        public PostRep(WorkContext db, IMapper mapper, IUserRep userRep)
        {
            this.db = db;
            this.mapper = mapper;
            this.userRep = userRep;
        }

        #endregion

        #region Actions
        public IEnumerable<PostVM> Get(Expression<Func<Post, bool>> filter = null)
        {
            try
            {

                if (filter == null)
                {
                    var data = GetPosts();
                    var model = mapper.Map<IEnumerable<PostVM>>(data);
                    return model;
                }
                else
                {
                    var data = db.Post.Where(filter);
                    var model = mapper.Map<IEnumerable<PostVM>>(data);
                    return model;
                }
            }
            catch
            {
                return Enumerable.Empty<PostVM>();
            }
        }


        public PostVM Create(PostVM obj)
        {
            var model = mapper.Map<Post>(obj);
            db.Post.Add(model);
            db.SaveChanges();

            var data = db.Post.OrderByDescending(a=>a.Id).FirstOrDefault();
            var ReturnedPost = mapper.Map<PostVM>(data);
            return ReturnedPost;

        }

        public void Delete(PostVM obj)
        {
            var model = mapper.Map<Post>(obj);
            db.Post.Remove(model);
            db.SaveChanges();
        }

        public void Edit(PostVM obj)
        {
            var model = mapper.Map<Post>(obj);
            db.Entry(model).State = EntityState.Modified;
            db.SaveChanges();

        }


        public PostVM GetById(int id)
        {
            var data = db.Post.Where(a => a.Id == id).FirstOrDefault();
            var model = mapper.Map<PostVM>(data);
            return model;
        }

        #endregion

        #region Refactory Methods
        private IQueryable<Post> GetPosts()
        {
            return db.Post.Select(a => a);
        }

        #endregion
    }
}
