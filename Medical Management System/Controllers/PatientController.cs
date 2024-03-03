using Microsoft.AspNetCore.Mvc;
using Medical_Management_System_Core;
using Medical_Management_System_Core.Services;
using Medical_Management_System_Service;
using Medical_Management_System_Core.Entities;
using Medical_Management_System.Models;
using Medical_Management_System_Core.DTOs;
using AutoMapper;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Medical_Management_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService _patientService;


        private readonly IMapper _mapper;

        // private readonly Mapping _mapping;


        public PatientController(IPatientService patientService, IMapper mapper)
        {
            _patientService = patientService;
            _mapper = mapper;
        }



        // GET: api/<AppointmentController>
        [HttpGet]
        public IActionResult Get()
        {
            var list = _patientService.GetPatients();
            var listDto = _mapper.Map<IEnumerable<PatientDto>>(list);
            return Ok(listDto);
        }

        // GET api/<AppointmentController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var patient = _patientService.GetById(id);
            if (patient is null)
            {
                return NotFound();
            }
            // var patientDto = _mapping.MapToPatientDto(patient);
            var patientDto = _mapper.Map<AppointmentDto>(patient);

            return Ok(patientDto);
        }

        // POST api/<AppointmentController>
        [HttpPost]
        public ActionResult Post([FromBody] PatientPostModel patient)
        {
            var patientToAdd = new Patient { DateOfBirth=patient.DateOfBirth,MedicalHistory=patient.MedicalHistory,PatientName=patient.PatientName };
            var newPatient  = _patientService.AddPatient(patientToAdd);
            return Ok(newPatient);

        }

        // PUT api/<AppointmentController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Patient patient)
        {
            return Ok(_patientService.UpdatePatient(id, patient));
        }

        // DELETE api/<AppointmentController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var patient = _patientService.GetById(id);
            if (patient is null)
            {
                return NotFound();
            }
            _patientService.DeletePatient(id);
            return NoContent();
        }
    }
}
