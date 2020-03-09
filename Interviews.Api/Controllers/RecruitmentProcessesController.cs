using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interviews.Services;
using Interviews.Services.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Interviews.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class RecruitmentProcessesController : CustomControllerBase
    {

        public RecruitmentProcessesController(IServiceFactory serviceFactory) : base(serviceFactory) { }

        // GET: api/RecruitmentProcesses
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var recluitmentProcesses = await Services.RecruiterProcessesService.GetRecruiterProcessesByUserIdAsync(CurrentUserId);
            return Ok(recluitmentProcesses);
        }

        // GET: api/RecruitmentProcesses/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<IActionResult> Get(long id)
        {
            var recluitmentProcess = await Services.RecruiterProcessesService.GetRecruiterProcess(CurrentUserId, id);
            return Ok(recluitmentProcess);
        }

        // POST: api/RecruitmentProcesses
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RecruiterProcesses model)
        {
            var response = await Services.RecruiterProcessesService.CreateRecruiterProcess(model, CurrentUserId);
            return Ok(response);
        }

        // PUT: api/RecruitmentProcesses/5
        /*[HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}
