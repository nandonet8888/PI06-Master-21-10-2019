using System;
using Microsoft.AspNetCore.Mvc;
using PI06.Data.Context;
using PI06.Models.Entity;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using PI06.Api.IServiceRepository;
using System.Threading.Tasks;


namespace PI06.Api.Controllers
{
    [Route("api/[controller]")]
    public class ConselhoController : Controller
    {
        private readonly IConselhoService _conselhoService;

        public ConselhoController(IConselhoService conselhoService)
        {


            _conselhoService = conselhoService;
        }


        [HttpGet]
        [ProducesResponseType(typeof(Conselho), 200)]
        public IActionResult Get()
        {

            var consultaAll = _conselhoService.GetAllIncludingProperties();

            return Json(consultaAll);

        }
        public IActionResult Post([FromBody] Conselho conselho) {

            if (conselho == null) {
                return BadRequest();
            }
            try
            {
                _conselhoService.AddAsync(conselho);
                return CreatedAtRoute("GetConselho", new { id = conselho.Id }, conselho);
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
                throw;
            }



        }

    }
}
