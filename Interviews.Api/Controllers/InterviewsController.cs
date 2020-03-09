using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Interviews.Common.Exceptions;
using Interviews.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Interviews.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class InterviewsController : CustomControllerBase
    {
        public InterviewsController(IServiceFactory serviceFactory) : base(serviceFactory) { }

        // GET: api/Interviews
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Interviews?date={date}
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] string date)
        {
            if (!DateTime.TryParseExact(date, "yyyy-mm-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out var dateTime))
            {
                throw new BadRequestCustomException("Formato de la fecha no valido", "");
            }

            var interviews = await Services.InterviewsService.GetInterviewsAsync(CurrentUserId, dateTime);
            return Ok(interviews);
        }

        // POST: api/Interviews
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Services.Models.Interviews model)
        {
            var response = await Services.InterviewsService.ScheduleInterviewAsync(CurrentUserId, model);
            return Ok(response);
        }

        // PUT: api/Interviews/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
