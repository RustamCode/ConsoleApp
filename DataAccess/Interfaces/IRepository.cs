﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Interfaces;

namespace DataAccess.Interfaces
{
   public interface IRepository<T>where T : IEntity
    {
        bool Create(T entity);
        bool Delete(T entity);
        bool Update(T entity);

        T GetOne(Predicate<T> filter = null);
        List<T> GetAll(Predicate<T> filter = null);
    }
}
