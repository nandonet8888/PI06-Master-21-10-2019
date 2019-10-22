using System;
using System.Linq;
using PI06.Data.Context;
using PI06.Models.Entity;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PI06.Helpers;
using PI06.Data.Models.Entity;
using PI06.Data.IRepository;

namespace PI06.IRepository.Repository
{
    public class ConsultaRepository : Repository<Consulta>, IConsultaRepository
    {
    
        public ConsultaRepository(Contexto context) : base(context) {



        }

        public IEnumerable<Consulta> GetAllIncludingProperties()
        {
            IQueryable<Consulta> query = dbSet.Include(p => p.Procedimento);
            return query.AsEnumerable();

        }

       
    }
}
