using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using DataAccess.Interfaces;
using Entities.Models;

namespace Business.Repository
{
    public class MedicineRepository : IRepository<Medicine>
    {
        public bool Create(Medicine entity)
        {
            try
            {
                DataContext.Medications.Add(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(Medicine entity)
        {
            try
            {
                DataContext.Medications.Remove(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Medicine> GetAll(Predicate<Medicine> filter = null)
        {
            try
            {
                return DataContext.Medications.FindAll(filter);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Medicine GetOne(Predicate<Medicine> filter = null)
        {
            try
            {
                return DataContext.Medications.Find(filter);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(Medicine entity)
        {
            try
            {
                Medicine isExist = GetOne(m => m.ID == entity.ID);
                return true;
            }
            catch (Exception)
            {
                 
                throw;
            }
        }
    }
}
