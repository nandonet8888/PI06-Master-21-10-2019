﻿using PI06.Data.Models.Entity;
using PI06.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace PI06.Data.IRepository
{
    public interface ITipoExameRepository : IRepository<TipoExame>
    {
        TipoExame tipoExame(string tipo);

         IEnumerable<TipoExame> GetAllIncludingProperties();

    }
}
