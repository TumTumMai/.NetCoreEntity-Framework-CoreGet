using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DBContexts;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TESTSController : ControllerBase
    {
        private MyDBContext myDbContext;

        public TESTSController(MyDBContext context)
        {
            myDbContext = context;
        }

        [HttpGet]
        public IList<TESTS> Get()
        {
            return (this.myDbContext.TEST.ToList());
        }
    }
}
