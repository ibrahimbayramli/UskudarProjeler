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
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CalisanlarsController : ApiController
    {
        private CrudDBEntities db = new CrudDBEntities();

        // GET: api/Calisanlars
        public IQueryable<Calisanlar> GetCalisanlars()
        {
            return db.Calisanlars;
        }

        // GET: api/Calisanlars/5
        [ResponseType(typeof(Calisanlar))]
        public async Task<IHttpActionResult> GetCalisanlar(int id)
        {
            Calisanlar calisanlar = await db.Calisanlars.FindAsync(id);
            if (calisanlar == null)
            {
                return NotFound();
            }

            return Ok(calisanlar);
        }

        // PUT: api/Calisanlars/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutCalisanlar(int id, Calisanlar calisanlar)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != calisanlar.CalisanID)
            {
                return BadRequest();
            }

            db.Entry(calisanlar).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CalisanlarExists(id))
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

        // POST: api/Calisanlars
        [ResponseType(typeof(Calisanlar))]
        public async Task<IHttpActionResult> PostCalisanlar(Calisanlar calisanlar)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Calisanlars.Add(calisanlar);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = calisanlar.CalisanID }, calisanlar);
        }

        // DELETE: api/Calisanlars/5
        [ResponseType(typeof(Calisanlar))]
        public async Task<IHttpActionResult> DeleteCalisanlar(int id)
        {
            Calisanlar calisanlar = await db.Calisanlars.FindAsync(id);
            if (calisanlar == null)
            {
                return NotFound();
            }

            db.Calisanlars.Remove(calisanlar);
            await db.SaveChangesAsync();

            return Ok(calisanlar);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CalisanlarExists(int id)
        {
            return db.Calisanlars.Count(e => e.CalisanID == id) > 0;
        }
    }
}