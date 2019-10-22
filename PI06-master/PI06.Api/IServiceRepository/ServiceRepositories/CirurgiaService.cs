using PI06.Data.IRepository;
using PI06.Data.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PI06.Api.IServiceRepository.ServiceRepositories
{
    public class CirurgiaService : ServiceBase<Cirurgia>, ICirurgiaService
    {
        private readonly ICirurgiaRepository _repository;

        public CirurgiaService(ICirurgiaRepository repository) : base(repository) {

            _repository = repository;
        }



        public IEnumerable<Cirurgia> GetAllIncludingProperties()
        {
            return _repository.GetAllIncludingProperties();
        }

     

        public void SalvarCirurgia(Cirurgia cirurgia)
        {
            _repository.SalvarCirurgia(cirurgia);
        }
    }
}
