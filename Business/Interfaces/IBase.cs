using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;

namespace Business.Interfaces
{
    public interface IBase
    {
        Base Create(Base Base);
        Base Update(int ID, Base Base);
        Base Delete(int ID);
        Base GetBase(string name);


    }
}
