﻿using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
   public  class Base:IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string MaxSize { get; set; }
    }
}