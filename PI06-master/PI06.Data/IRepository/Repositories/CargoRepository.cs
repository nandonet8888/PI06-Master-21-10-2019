using Microsoft.EntityFrameworkCore;
using PI06.Data.Context;
using PI06.Data.IRepository;
using PI06.IRepository.Repository;
using PI06.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PI06.Data.IRepository.Repository
{
    public class CargoRepository : Repository<Cargo>, ICargoRepository
    {

        private readonly Cargo cargoC;
        public CargoRepository(Contexto context) : base(context)
        {

        }

        public Cargo CargoExistente(string cargo)
        {
            var procurarCargo = dbSet.Find(cargoC.DescricaoCargo.Equals(cargo));
            return procurarCargo;
        }
        public IEnumerable<Cargo> GetAllIncludingProperties() { 
            IQueryable<Cargo> query = dbSet.Include(f =>f.Funcionario);
            return query.AsEnumerable();

        }



    }
}
