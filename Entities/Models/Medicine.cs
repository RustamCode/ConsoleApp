using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Interfaces;

namespace Entities.Models
{
   public class Medicine:IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
