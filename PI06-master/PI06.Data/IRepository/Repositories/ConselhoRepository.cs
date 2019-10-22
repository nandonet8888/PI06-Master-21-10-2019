using System;
using System.Linq;
using PI06.Data.Context;
using PI06.Models.Entity;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PI06.Helpers;
using PI06.Data.IRepository;

namespace PI06.IRepository.Repository
{
   public  class ConselhoRepository : Repository<Conselho> , IConselhoRepository
    {
        private readonly Conselho conselho;
        public ConselhoRepository(Contexto context) : base(context)
        {
        }
        public Conselho ConselhosExistente(string conselhosE) {

            var existente = dbSet.Find(conselho.DescricaoConselho.Equals(conselhosE));
            return existente;

        }

        public IEnumerable<Conselho> GetAllIncludingProperties()
        {
            IQueryable<Conselho> query = dbSet.Include(f => f.Funcionario);
            return query.AsEnumerable();
        }
    }
}
