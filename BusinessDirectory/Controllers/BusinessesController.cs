using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessDirectory.Models;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Mvc.Versioning;



namespace BusinessDirectory.Controllers.v1
{
  [ApiController]
  [ApiVersion("1.0")]
  [Route("api/v1/Businesses")]
  
  public class BusinessesV1Controller : ControllerBase
  {
    private readonly BusinessDirectoryContext _db;

    public BusinessesV1Controller(BusinessDirectoryContext db)
    {
      _db = db;
    }

    // GET: api/Businesses

    [HttpGet]
    [ApiVersion("1.0")]
    public async Task<ActionResult<IEnumerable<Business>>> Get(string businesstype, string name, string website)
    {
      var query = _db.Businesses.AsQueryable();

      if (businesstype != null)
      {
        query = query.Where(entry => entry.BusinessType == businesstype);
      }

      if (name != null)
      {
        query = query.Where(entry => entry.BusinessName == name);
      } 

      if (website != null)
      {
        query = query.Where(entry => entry.BusinessWebsite == website);
      }


      return await query.ToListAsync();
    }

    // GET: api/Businesses/5

    [HttpGet("{id}")]
    public async Task<ActionResult<Business>> GetBusiness(int id)
    {
        var business = await _db.Businesses.FindAsync(id);

        if (business == null)
        {
            return NotFound();
        }

        return business;
    }

    // PUT: api/Businesses/5

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Business business)
    {
      if (id != business.BusinessId)
      {
        return BadRequest();
      }

      _db.Entry(business).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!BusinessesExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }

    // POST: api/Businesses

    [HttpPost]
    public async Task<ActionResult<Business>> Post(Business business)
    {
      _db.Businesses.Add(business);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetBusiness), new { id = business.BusinessId }, business);
    }

    // DELETE: api/Businesses/5

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteBusiness(int id)
    {
      var business = await _db.Businesses.FindAsync(id);
      if (business == null)
      {
        return NotFound();
      }

      _db.Businesses.Remove(business);
      await _db.SaveChangesAsync();

      return NoContent();
    }
    
    private bool BusinessesExists(int id)
    {
      return _db.Businesses.Any(e => e.BusinessId == id);
    }
  }
}
