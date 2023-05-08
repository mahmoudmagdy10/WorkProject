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
    public class RateRep : IRateRep
    {
        #region Fields

        private readonly WorkContext db;
        private readonly IMapper mapper;

        #endregion

        #region Ctor
        public RateRep(WorkContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        #endregion
        public void Create(RateVM obj)
        {
            var model = mapper.Map<Rate>(obj);
            var RateModel = db.Rate.Where(a => a.UserId == model.UserId).Where(a => a.Sender == model.Sender).FirstOrDefault();

            if (RateModel == null)
            {
                db.Rate.Add(model);
                db.SaveChanges();
            }
            else 
            {
                RateModel.Value = model.Value;
                db.SaveChanges();
            }
        }

        public void Edit(RateVM obj)
        {
            var model = mapper.Map<Rate>(obj);
            db.Entry(model).State = EntityState.Modified;
            db.SaveChanges();
        }

        public IEnumerable<RateVM> Get(Expression<Func<Rate, bool>> filter = null)
        {
            try
            {

                if (filter == null)
                {
                    var data = GetRates();
                    var model = mapper.Map<IEnumerable<RateVM>>(data);
                    return model;
                }
                else
                {
                    var data = db.Rate.Where(filter);
                    var model = mapper.Map<IEnumerable<RateVM>>(data);
                    return model;
                }
            }
            catch
            {
                return Enumerable.Empty<RateVM>();
            }
        }

        #region Refactory Methods
        private IQueryable<Rate> GetRates()
        {
            return db.Rate.Select(a => a);
        }

        #endregion
    }
}
