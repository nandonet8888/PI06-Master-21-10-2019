﻿using System;
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
    public class TipoExameController : Controller
    {
        private readonly ITipoExameService _tipoExameService;

        public TipoExameController(ITipoExameService tipoExameService)
        {
            _tipoExameService = tipoExameService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(TipoExame), 200)]
        public IActionResult Get() {

            var consultaAll = _tipoExameService.GetAllIncludingProperties();
            return Json(consultaAll);
        }



    }
}
