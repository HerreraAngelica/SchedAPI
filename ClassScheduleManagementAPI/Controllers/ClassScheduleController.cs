using BusinessLayer;
using Microsoft.AspNetCore.Mvc;
using Models1;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClassSchedManagementAPI.Controllers
{
    [ApiController]
    [Route("api/schedule")]
    public class ScheduleController : ControllerBase
    {
        private readonly BusinessServices _businessServices;

        public ScheduleController()
        {
            _businessServices = new BusinessServices();
        }

        //[HttpGet("classSchedules")]
        //public async Task<IActionResult> GetClassSchedules()
        //{
        //    var schedules = await _businessServices.GetSchedulesAsync();
        //    return Ok(schedules);
        //}

        //[HttpPost("addSchedule")]
        //public async Task<IActionResult> AddSchedule([FromBody] Schedule schedule)
        //{
        //    var result = await _businessServices.AddScheduleAsync(schedule);
        //    return result ? Ok(new { Success = true }) : BadRequest(new { Success = false, Message = "Schedule already exists." });
        //}

        //[HttpDelete("deleteSchedule")]
        //public async Task<IActionResult> DeleteSchedule([FromQuery] string className, [FromQuery] string subject, [FromQuery] string professor)
        //{
        //    var result = await _businessServices.DeleteScheduleAsync(className, subject, professor);
        //    return result ? Ok(new { Success = true }) : NotFound(new { Success = false, Message = "Schedule not found." });
        //}
    }
}
