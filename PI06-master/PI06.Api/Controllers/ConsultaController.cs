using Microsoft.AspNetCore.Mvc;
using PI06.Data.Context;
using PI06.Models.Entity;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using PI06.Api.IServiceRepository;
using System.Threading.Tasks;
using PI06.Data.Models.Entity;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PI06.Api.Controllers
{
    [Route("api/[controller]")]
    public class ConsultaController : Controller
    {
        private readonly IConsultaService _consultaService;

        public ConsultaController(IConsultaService consultaService) {

            _consultaService = consultaService;

        }

        [HttpGet]
        [ProducesResponseType(typeof(Consulta), 200)]
        public IActionResult Get() {
            var consultaAll = _consultaService.GetAllIncludingProperties();

            return Json(consultaAll);

        }



    }
}
