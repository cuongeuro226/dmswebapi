using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using DMWEB.Models;

namespace DMWEB.Controllers
{
    public class CurrentLocationTrackingsController : ApiController
    {
        private DMSContext db = new DMSContext();

        // GET: api/CurrentLocationTrackings
        public IQueryable<CurrentLocationTracking> GetCurrentLocationTrackings()
        {
            return db.CurrentLocationTrackings;
        }

        // GET: api/CurrentLocationTrackings/5
        [ResponseType(typeof(CurrentLocationTracking))]
        public async Task<IHttpActionResult> GetCurrentLocationTracking(Guid id)
        {
            CurrentLocationTracking currentLocationTracking = await db.CurrentLocationTrackings.FindAsync(id);
            if (currentLocationTracking == null)
            {
                return NotFound();
            }

            return Ok(currentLocationTracking);
        }

        // PUT: api/CurrentLocationTrackings/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutCurrentLocationTracking(Guid id, [FromBody]CurrentLocationTracking currentLocationTracking)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != currentLocationTracking.NVID)
            {
                return BadRequest();
            }

            db.Entry(currentLocationTracking).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CurrentLocationTrackingExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/CurrentLocationTrackings
        [ResponseType(typeof(CurrentLocationTracking))]
        public async Task<IHttpActionResult> PostCurrentLocationTracking([FromBody]CurrentLocationTracking currentLocationTracking)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CurrentLocationTrackings.Add(currentLocationTracking);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CurrentLocationTrackingExists(currentLocationTracking.NVID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = currentLocationTracking.NVID }, currentLocationTracking);
        }

        // DELETE: api/CurrentLocationTrackings/5
        [ResponseType(typeof(CurrentLocationTracking))]
        public async Task<IHttpActionResult> DeleteCurrentLocationTracking(Guid id)
        {
            CurrentLocationTracking currentLocationTracking = await db.CurrentLocationTrackings.FindAsync(id);
            if (currentLocationTracking == null)
            {
                return NotFound();
            }

            db.CurrentLocationTrackings.Remove(currentLocationTracking);
            await db.SaveChangesAsync();

            return Ok(currentLocationTracking);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CurrentLocationTrackingExists(Guid id)
        {
            return db.CurrentLocationTrackings.Count(e => e.NVID == id) > 0;
        }
    }
}