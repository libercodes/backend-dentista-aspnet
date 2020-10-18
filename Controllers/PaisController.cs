using System.Collections.Generic;
using AutoMapper;
using backend.DTOs.Localizacion;
using backend.Models;
using backend.Services;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/pais")]
    public class PaisController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IService<Pais> _service;

        public PaisController(IMapper mapper, IService<Pais> s)
        {
            _mapper = mapper;
            _service = s;
        }

        [HttpPost]
        public ActionResult<PaisReadDTO> Create(PaisCreateDTO paisDTO)
        {
            Pais pais = _mapper.Map<Pais>(paisDTO);
            _service.Create(pais);

            PaisReadDTO PaisReadDTO = _mapper.Map<PaisReadDTO>(pais);
            //return CreatedAtRoute(nameof(GetById), new { id = PaisReadDTO.Id }, PaisReadDTO);
            return Ok(PaisReadDTO);
        }

        [HttpGet("{id}")]
        public ActionResult<PaisReadDTO> GetById(int id)
        {
            var obj = _service.GetById(id);
            if (obj == null) return NotFound();
            return Ok(_mapper.Map<PaisReadDTO>(obj));

        }

        [HttpGet]
        public ActionResult<IEnumerable<PaisReadDTO>> GetAll()
        {
            var list = _service.GetAll();
            return Ok(_mapper.Map<IEnumerable<PaisReadDTO>>(list));
        }

        [HttpPut]
        public ActionResult<IEnumerable<PaisReadDTO>> Update(PaisUpdateDTO paisDTO)
        {
            Pais pais = _mapper.Map<Pais>(paisDTO);
            var obj = _service.Update(pais);
            return Ok(_mapper.Map<PaisReadDTO>(obj));
        }

        [HttpDelete]
        public ActionResult<IEnumerable<PaisReadDTO>> DeleteById(int id)
        {
            var obj = _service.DeleteById(id);
            return Ok(_mapper.Map<PaisReadDTO>(obj));
        }
    }
}