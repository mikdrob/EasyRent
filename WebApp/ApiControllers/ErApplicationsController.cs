using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Applications.DAL.App;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApp.ApiControllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ErApplicationsController : ControllerBase
    {
        private readonly IAppUnitOfWork _uow;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="uow"></param>
        public ErApplicationsController(IAppUnitOfWork uow)
        {
            _uow = uow;
        }

        // GET: api/ErApplications
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DAL.App.DTO.ErApplication>>> GetErApplications()
        {
            return Ok(await _uow.ErApplications.GetAllAsync());
        }

        // GET: api/ErApplications/5
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<DAL.App.DTO.ErApplication>> GetErApplication(Guid id)
        {
            var erApplication = await _uow.ErApplications.FirstOrDefaultAsync(id);

            if (erApplication == null)
            {
                return NotFound();
            }

            return erApplication;
        }

        // PUT: api/ErApplications/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="erApplication"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutErApplication(Guid id, DAL.App.DTO.ErApplication erApplication)
        {
            if (id != erApplication.Id)
            {
                return BadRequest();
            }

            _uow.ErApplications.Update(erApplication);
            await _uow.SaveChangesAsync();
            return NoContent();
        }

        // POST: api/ErApplications
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        /// <summary>
        /// 
        /// </summary>
        /// <param name="erApplication"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<DAL.App.DTO.ErApplication>> PostErApplication(DAL.App.DTO.ErApplication erApplication)
        {
            _uow.ErApplications.Add(erApplication);
            await _uow.SaveChangesAsync();

            return CreatedAtAction("GetErApplication", new { id = erApplication.Id }, erApplication);
        }

        // DELETE: api/ErApplications/5
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteErApplication(Guid id)
        {
            var erApplication = await _uow.ErApplications.FirstOrDefaultAsync(id);
            if (erApplication == null)
            {
                return NotFound();
            }

            _uow.ErApplications.Remove(erApplication);
            await _uow.SaveChangesAsync();

            return NoContent();
        }
    }
}
