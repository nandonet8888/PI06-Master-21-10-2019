using Microsoft.EntityFrameworkCore;
using PI06.Data.Context;
using PI06.Data.Models.Entity;
using PI06.IRepository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PI06.Data.IRepository.Repositories
{
    public class TipoExameRepository :  Repository<TipoExame> , ITipoExameRepository
    {
        private readonly TipoExame Texame;
        public TipoExameRepository(Contexto context) : base(context) { }

        public IEnumerable<TipoExame> GetAllIncludingProperties()
        {
            IQueryable<TipoExame> query = dbSet.Include(te => te.Exame);
            return query.AsEnumerable();
        }

        public TipoExame tipoExame(string tipo)
        {
            var existenteTipo = dbSet.Find(Texame.Descricao.Equals(tipo));
            return existenteTipo;
        }

       
    }
}
