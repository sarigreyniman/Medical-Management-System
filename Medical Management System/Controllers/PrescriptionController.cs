using Medical_Management_System_Service;
using Microsoft.AspNetCore.Mvc;
using Medical_Management_System_Core;
using Medical_Management_System_Core.Services;
using Medical_Management_System_Core.Entities;
using Medical_Management_System.Models;
using Medical_Management_System_Core.DTOs;
using AutoMapper;

namespace Medical_Management_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrescriptionController : ControllerBase
    {
        private readonly IPrescriptionService _prescriptionService;


        private readonly IMapper _mapper;
        //private readonly Mapping _mapping;


        public PrescriptionController(IPrescriptionService prescriptionService, IMapper mapper)
        {
            _prescriptionService = prescriptionService;
            _mapper = mapper;
        }



        // GET: api/<AppointmentController>
        [HttpGet]
        public IActionResult Get()
        {
            var list = _prescriptionService.GetPrescriptionsAsync();
            var listDto = _mapper.Map<IEnumerable<PrescriptionDto>>(list);
            return Ok(listDto);
        }

        // GET api/<AppointmentController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var prescription = _prescriptionService.GetByIdAsync(id);
            if (prescription is null)
            {
                return NotFound();
            }
            // var prescriptionDto = _mapping.MapToPrescriptionDto(prescription);
            var prescriptionDto = _mapper.Map<PrescriptionDto>(prescription);
            return Ok(prescriptionDto);
        }

        // POST api/<AppointmentController>
        [HttpPost]
        public ActionResult Post([FromBody] PrescriptionPostModel prescription)
        {
            var prescriptionToAdd = new Prescription { Dosage = prescription.Dosage, Medication = prescription.Medication, PatientId = prescription.PatientId };
            var newPrescription = _prescriptionService.AddPrescriptionAsync(prescriptionToAdd);
            return Ok(newPrescription);

        }

        // PUT api/<AppointmentController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Prescription prescription)
        {
            return Ok(_prescriptionService.UpdatePrescriptionAsync(id, prescription));

        }

        // DELETE api/<AppointmentController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var prescription = _prescriptionService.GetByIdAsync(id);
            if (prescription is null)
            {
                return NotFound();
            }
            _prescriptionService.DeletePrescriptionAsync(id);
            return NoContent();
        }
    }
}
