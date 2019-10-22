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
    public class TipoProcedimentoRepository : Repository<TipoProcedimento> , ITipoProcedimentoRepository 
    {
        private readonly TipoProcedimento TipoProcessedimento;
        public TipoProcedimentoRepository(Contexto context) : base(context) {

        }

        

        public TipoProcedimento TipoProcedimentoE(string TipoPro)
        {
            var procedimento = dbSet.Find(TipoProcessedimento.Descricao.Equals(TipoPro));

            return procedimento;

        }

        public IEnumerable<TipoProcedimento> GetAllIncludingProperties() {
            
                IQueryable<TipoProcedimento> query = dbSet.Include(te => te.Procedimentos);
                return query.AsEnumerable();
            }



        }
    }

