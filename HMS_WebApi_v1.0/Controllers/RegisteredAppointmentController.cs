﻿using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repo;

namespace HMS_WebApi_v1._0.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegisteredAppointmentController : ControllerBase
    {
        private readonly IRegisteredAppointment _registeredAppointmentRepo;

        public RegisteredAppointmentController(IRegisteredAppointment registeredAppointmentRepo)
        {
            _registeredAppointmentRepo = registeredAppointmentRepo;
        }


        [HttpGet(Name = "GetAppointments")]
        public async Task<IActionResult> GetAppointments()
        {
            var appointments  = await _registeredAppointmentRepo.GetAppointments();
            return Ok(appointments);
        }

        [HttpPost(Name = "AddAppointment")]
        public async Task<IActionResult> AddAppointment(RegisteredAppointment appointment)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            await _registeredAppointmentRepo.AddAppointment(appointment);
            return Ok(appointment);
        }
    }
}
