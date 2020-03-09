using System.Collections.Generic;
using System.Threading.Tasks;
using Interviews.Common.Exceptions;
using Interviews.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Interviews.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class TechnologiesController : CustomControllerBase
    {

        public TechnologiesController(IServiceFactory serviceFactory) : base(serviceFactory) { }

        [HttpGet("parents")]
        public async Task<IActionResult> GetTechnologiesParents()
        {
            var techologies = await Services.TechnologiesService.GetParentTechnologiesAsync();
            return Ok(techologies);
        }

        // GET: api/Technologies/5
        [HttpGet("{id}/children")]
        public async Task<IActionResult> GetChildren(long id)
        {
            if(id == 0)
            {
                throw new BadRequestCustomException("Debe indicar un id valido", "");
            }

            var technologies = await Services.TechnologiesService.GetChildrenTechnologiesAsync(id);
            return Ok(technologies);
        }
    }
}
