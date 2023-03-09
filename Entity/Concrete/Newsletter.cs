﻿using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Newsletter : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Mail { get; set; }
    }
}
