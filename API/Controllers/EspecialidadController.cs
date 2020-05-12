using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Application.Services;
using Domain.DTOs;
using Domain.Entities;


namespace API.Controllers {

    [Route("api/[controller]")]
    [ApiController]
    public class EspecialidadController : ControllerBase {
        private readonly IEspecialidadServices _service;

        public EspecialidadController(IEspecialidadServices service) {
            _service = service;
        }

        [HttpPost]
        public ActionResult<Especialidad> Post(EspecialidadDto especialidad) {
            return StatusCode(201, _service.CreateEspecialidad(especialidad));
        }

        [HttpGet]
        public IActionResult GetEspecialidades([FromQuery] string q) {
            try {
                return new JsonResult(_service.SearchEspecialidad(q)) { StatusCode = 200 };
            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }
    }
}