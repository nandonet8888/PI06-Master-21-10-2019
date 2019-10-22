using Microsoft.AspNetCore.Mvc;
using PI06.Data.Context;
using PI06.Models.Entity;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using PI06.Api.IServiceRepository;
using System.Threading.Tasks;
using PI06.Data.Models.Entity;
using PI06.Data.IRepository;
using System;

namespace PI06.Api.Controllers
{
    [Route("api/[controller]")]
    public class CargoController: Controller
    {
        private readonly Contexto contexto;

        private readonly ICargoService _cargoService;

        public CargoController(Contexto contexto, ICargoService cargoService)
        {
            this.contexto = contexto;
            this._cargoService = cargoService;
        }
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Cargo), 200)]
        public IActionResult GetPorId(int id)
        {
            var cargo = contexto.Cargo.FirstOrDefault(
                x => x.Id == id);


            return new ObjectResult(cargo);
        }

        [HttpGet]
        [ProducesResponseType(typeof(Cargo),200)]
        public IActionResult Get() {

            var consultaAll = _cargoService.GetAllIncludingProperties();
            return Json(consultaAll);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Cargo cargo)
        {
            if (cargo == null) {

                return BadRequest();

            }
            try
            {
                _cargoService.AddAsync(cargo);
                return CreatedAtRoute("GetCargo", new {id = cargo.Id },cargo);


            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
                throw;
            }


        }

    }

    }
