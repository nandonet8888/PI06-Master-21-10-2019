﻿using PI06.Data.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PI06.Api.IServiceRepository
{
    public interface ICirurgiaService : IServiceBase<Cirurgia>
    {
        IEnumerable<Cirurgia> GetAllIncludingProperties();

        void SalvarCirurgia(Cirurgia cirurgia);
    }
}
