using AutoMapper;
using Medical_Management_System.Models;
using Medical_Management_System_Core;
using Medical_Management_System_Core.DTOs;
using Medical_Management_System_Core.Entities;
using Medical_Management_System_Core.Services;
using Medical_Management_System_Service;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;


namespace Medical_Management_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;


        private readonly IMapper _mapper;
        //private readonly Mapping _mapping;


        public AppointmentController(IAppointmentService appointmentService,IMapper mapper)
        {
            _appointmentService = appointmentService;
            _mapper = mapper;
        }
         

        // GET: api/<AppointmentController>
        [HttpGet]
        public IActionResult Get()
        {
            var list = _appointmentService.GetAppointmentes();
            var listDto = _mapper.Map<IEnumerable<AppointmentDto>>(list);
            return Ok(listDto);
        }

        // GET api/<AppointmentController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var appointment = _appointmentService.GetById(id);

            if (appointment is null)
            {
                return NotFound();
            }
            // var appointmentDto = _mapping.MapToAppointmentDto(appointment);
            var appointmentDto = _mapper.Map<AppointmentDto>(appointment);
            return Ok(appointmentDto);
        }

        // POST api/<AppointmentController>
        [HttpPost]
        public ActionResult Post([FromBody] AppointmentPostModel appointment)
        {
            var appointmentToAdd = new Appointment { AppointmentDate=appointment.AppointmentDate,DoctorName=appointment.DoctorName,PatientId=appointment.PatientId };
            var newAppointment = _appointmentService.AddAppointment(appointmentToAdd);
            return Ok(newAppointment);
        }

        // PUT api/<AppointmentController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Appointment appointment)
        {
            return Ok(_appointmentService.UpdateAppointment(id, appointment));

        }

        // DELETE api/<AppointmentController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var appointment = _appointmentService.GetById(id);
            if (appointment is null)
            {
                return NotFound();
            }
            _appointmentService.DeleteAppointment(id);
            return NoContent();
        }
    }
}
