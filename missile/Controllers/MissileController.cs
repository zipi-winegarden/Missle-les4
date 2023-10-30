using Api.model;
using Api.Serivce;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using System.Reflection;
using WebApplication1.model;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MissileController : ControllerBase
    {
      
        public MissileController()
        {
           
        }
        MissileService missileList = new MissileService();//רשימה טילים
        [HttpGet]
        public IEnumerable<Missile> GetMissile()
        {
           return missileList. GetData();
        }
        
        [HttpPost]
        public bool post(Missile missile)
        {   
            return missileList.add (missile);
        }

        [HttpGet]
        [Route("GetByPlace")]
        public IEnumerable<Missile> GetbyPlace(string c)
        {
            return missileList.GetbyPlace(c);
        }

        [HttpGet]
        [Route("GetPlace")]
        public IEnumerable<string> GetPlace()
        {
            return missileList.GetPlace();
        }
    }
}
