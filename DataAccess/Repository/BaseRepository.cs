using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using DataAccess.Interfaces;
using Entities.Models;

namespace DataAccess.Repository
{
    public class BaseRepository:IRepository<Base>
    {
        public bool Create(Base entity)
        {
            try
            {
                DataContext.Bases.Add(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(Base entity)
        {
            try
            {
                DataContext.Bases.Remove(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Base> GetAll(Predicate<Base> filter = null)
        {
            try
            {
                return DataContext.Bases.FindAll(filter);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Base GetOne(Predicate<Base> filter = null)
        {
            try
            {
                return filter == null ? DataContext.Bases[0] :
                 DataContext.Bases.Find(filter);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(Base entity)
        {
            try
            {
                Base isExist = GetOne(m => m.ID == entity.ID);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
