using PI06.Data.IRepository;
using PI06.Data.Models.Entity;
using PI06.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PI06.Api.IServiceRepository.ServiceRepositories
{
    public class TipoExameService : ServiceBase<TipoExame>, ITipoExameService
    {
        private readonly ITipoExameRepository _repository;

        public TipoExameService(ITipoExameRepository repository) : base(repository) {

            _repository = repository;
        }




       public IEnumerable<TipoExame> GetAllIncludingProperties()
        {
            return _repository.GetAllIncludingProperties();
        }

        public TipoExame tipoExameExiste(string tipo)
        {
            return _repository.tipoExame(tipo);
        }
    }
}
