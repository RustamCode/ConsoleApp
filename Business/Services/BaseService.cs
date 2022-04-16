using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Interfaces;
using DataAccess.Repository;
using Entities.Models;

namespace Business.Services
{
    public class BaseService : IBase
    {
        public static int Count { get; set; }
        private BaseRepository _baseRepository;
        public BaseService(BaseRepository baseRepository)
        {
            _baseRepository = baseRepository;
        }
        public Base Create(Base Base)
        {
            Base.ID = Count;
            _baseRepository.Create(Base);
            Count++;
            return Base;
        }

        public Base Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public Base GetBase(string name)
        {
            throw new NotImplementedException();
        }

        public Base Update(int ID, Base Base)
        {
            throw new NotImplementedException();
        }
    }
}
