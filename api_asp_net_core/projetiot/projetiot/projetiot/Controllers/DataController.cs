using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using projetiot.Data;
using projetiot.Models;

namespace projetiot.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {

        private readonly DataDbContext _db;

       public DataController(DataDbContext db)
        {
            _db = db;
        }
        [HttpGet("{temp}/{humidite}/{vitesseVent}/{soleil}")]
        public async Task<IActionResult> addData(string? temp,string? humidite,string? vitesseVent,string? soleil)
        {

            IOTdata iOTdata = new IOTdata
            {
                Temperature=temp,
                Hmidite=humidite,
                vitesse=vitesseVent,
                soleil=soleil
            };
            _db.IOTdatas.Add(iOTdata);

            await _db.SaveChangesAsync();

            return Ok(iOTdata);

        }
        [HttpGet("AllData")]
        public async Task<IActionResult> AllData()
        {
           var Data = await _db.IOTdatas.ToListAsync();
            return Ok(Data);
        }
    }
}
