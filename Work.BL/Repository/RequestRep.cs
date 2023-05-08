using AutoMapper;
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
    public class RequestRep : IRequestRep
    {
        #region Fields

        private readonly WorkContext db;
        private readonly IMapper mapper;

        #endregion

        #region Ctor
        public RequestRep(WorkContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        #endregion

        #region Actions

        public RequestVM Create(RequestVM obj)
        {
            var model = mapper.Map<Request>(obj);
            db.Request.Add(model);
            db.SaveChanges();

            var data = db.Request.OrderByDescending(a => a.Id).FirstOrDefault();
            var ReturnedPost = mapper.Map<RequestVM>(data);
            return ReturnedPost;
        }

        public void Delete(RequestVM obj)
        {
            var model = mapper.Map<Request>(obj);
            db.Request.Remove(model);
            db.SaveChanges();
        }

        public void Edit(RequestVM obj)
        {
            var model = mapper.Map<Request>(obj);
            db.Entry(model).State = EntityState.Modified;
            db.SaveChanges();
        }

        public IEnumerable<RequestVM> Get(Expression<Func<Request, bool>> filter = null)
        {
            try
            {

                if (filter == null)
                {
                    var data = GetRequests();
                    var model = mapper.Map<IEnumerable<RequestVM>>(data);
                    return model;
                }
                else
                {
                    var data = db.Request.Where(filter);
                    var model = mapper.Map<IEnumerable<RequestVM>>(data);
                    return model;
                }
            }
            catch
            {
                return Enumerable.Empty<RequestVM>();
            }
        }

        public RequestVM GetById(int id)
        {
            try
            {
                var data = db.Request.Where(a => a.Id == id).FirstOrDefault();
                var model = mapper.Map<RequestVM>(data);
                return model;
            }
            catch
            {
                return new RequestVM();
            }
        }

        #endregion

        #region Refactory Methods
        private IQueryable<Request> GetRequests()
        {
            return db.Request.Select(a => a);
        }

        #endregion
    }
}
