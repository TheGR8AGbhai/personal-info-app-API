using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using PersonalInfoApi.Data;
using PersonalInfoApi.Models;

namespace PersonalInfoApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class UserController : ControllerBase
    {
        private readonly UserContext _context;

        public UserController(UserContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<UserDetails>> PostUser(UserDetails user)
        {
            _context.UserDetails.Add(user);
            await _context.SaveChangesAsync();
            if (user.ID == Guid.Empty)
            {
                return BadRequest("ID was not generated.");
            }
            return CreatedAtAction(nameof(GetUser), new { id = user.ID }, new { id = user.ID });
        }

        [HttpGet("{id}")]
        public async
            Task<ActionResult<UserDetails>>
            GetUser(Guid id)
        {
            var user = await
                _context.UserDetails.FindAsync(id);

            if (user == null) { return NotFound(); }
            return user;
        }

        
    }

}
