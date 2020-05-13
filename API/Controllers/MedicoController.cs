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
    public class MedicoController : ControllerBase {
        private readonly IMedicoServices _service;

        public MedicoController(IMedicoServices service) {
            _service = service;
        }

        [HttpPost]
        public ActionResult<Medico> Post(MedicoDto medico) {
            return StatusCode(201, _service.CreateMedico(medico));
        }

        [HttpGet]
        public IActionResult GetMedico([FromQuery] string q) {
            try {
                return new JsonResult(_service.SearchMedico(q)) { StatusCode = 200 };
            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
        }
    }
}