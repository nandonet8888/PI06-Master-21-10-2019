﻿using PI06.Models.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PI06.Data.Models.Entity
{
   public  class Exame : EntityBase
    {
        public string Resultado { get; set; }
        public TipoExame TipoExame { get; set; }
        public int IdTipoExame { get; set; }
        public Procedimento Procedimento { get; set; }

        
    }
}
