using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BPT.Test.CETM.BackEnd.Dominio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BPT.Test.CETM.BackEnd.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly DbApplicationContext context;
        public WeatherForecastController(DbApplicationContext _context)
        {
            this.context = _context;
        }

        [HttpGet]
        public IEnumerable<Asignacion> Get()
        {
            //string[] nombres = new string[] { "Juan","Lucas","Carlos","Maria" };
            try
            {

                return context.Asignaciones.ToList();
            }
            catch (Exception ex)
            {

                throw;
            }


        }
        [HttpGet("{id}")]
        public IEnumerable<Asignacion> GetId(int id)
        {
            //string[] nombres = new string[] { "Juan","Lucas","Carlos","Maria" };
            try
            {
               
               
                return context.Asignaciones.Where(p => p.Id==id).ToList();
            }
            catch (Exception ex)
            {

                throw;
            }


        }
    }
}
