using Microsoft.EntityFrameworkCore;
using PI06.Data.Context;
using PI06.Data.IRepository;
using PI06.Data.Models.Entity;
using PI06.IRepository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PI06.IRepository.Repository

{
    public class CirurgiaRespository : Repository<Cirurgia>,ICirurgiaRepository 
    {

        private readonly Cirurgia cirurgia;
        public CirurgiaRespository(Contexto context) : base(context)
        {
        }

        public IEnumerable<Cirurgia> GetAllIncludingProperties()
        {
            IQueryable<Cirurgia> query = dbSet.Include(p => p.Procedimento);

            return query.AsEnumerable();
        }

        public Cirurgia GetByIdIncludingProperties(int idCargo)
        {
            IQueryable<Cirurgia> query = dbSet.Include(pro=>pro.Procedimento).Where(i => i.Id == idCargo)
                .OrderBy(j => j.Id);

            return query.FirstOrDefault();

        }

        public Cirurgia CirurgiaExistente(string descricao) {

            var consulta = dbSet.Find(cirurgia.Descricao.Equals(descricao));
            return consulta;
    }



    public void SalvarCirurgia(Cirurgia cirurgia) {

            AddOrUpdate(cirurgia);
           
            Commit();

           
        }

    }
}
