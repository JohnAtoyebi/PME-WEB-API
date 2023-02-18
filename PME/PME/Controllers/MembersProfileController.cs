using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PME.Core.DTOs;
using PME.Services.Interfaces;
using System.Threading.Tasks;

namespace PME.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembersProfileController : ControllerBase
    {
        private readonly IPersonalDetailsRepository _personalDetails;
        public MembersProfileController(IPersonalDetailsRepository personalDetails)
        {
            _personalDetails = personalDetails;
        }
        [HttpPost]
        public async Task<IActionResult> CreateMember(PersonalDetailsDto model)
        {
            var request = await _personalDetails.CreateMember(model);
            if (request == null) return BadRequest(ModelState);
            return Ok(model);
        }
        [HttpGet("ById")]
        public async Task<IActionResult> GetMemberById(string memberId)
        {
            var request = await _personalDetails.GetMemberByIdAsync(memberId);
            if (request == null) return BadRequest(ModelState);
            return Ok(request);
        }
        [HttpGet("AllMembers")]
        public async Task<IActionResult> GetAllMembers()
        {
            var request = await _personalDetails.GetAllMembersAsync();
            if(request == null) return BadRequest(ModelState);
            return Ok(request);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateMember(string memberId, PersonalDetailsDto model)
        {
            var request = await _personalDetails.UpdateMember(memberId, model);
            if(request == null) return BadRequest(ModelState);
            return Ok(request);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteMember(string memberId)
        {
            var request = await _personalDetails.DeleteMemberById(memberId);
            if(request == null) return NotFound();
            return Ok(request);
        }
    }
}
