using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;

namespace DataAccess
{
    public class DataContext
    {
        public static List<Medicine> Medications { get; set; }
        public static List<Base> Bases { get; set; }

        static DataContext()
        {
            Medications = new List<Medicine>();
            Bases = new List<Base>();
        }
    }
}
