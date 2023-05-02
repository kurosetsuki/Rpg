using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using my0502.Services;

namespace my0502.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RpgController : ControllerBase
    {
        private Rpgservice _service;

        public RpgController()
        {
            _service = new Rpgservice();
        }
        
        [HttpGet]
        public Rpg Get(int id)
        {
            Rpg result = null;

            result =_service.Get(id);

            return result;
        }


        public Rpg Post(Rpg rpg)
        {
            Rpg result = null;
            result = _service.Create(rpg);
            return result;
        }
    }
}
