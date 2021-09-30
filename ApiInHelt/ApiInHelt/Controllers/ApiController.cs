using ApiInHelt.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiInHelt.Controllers
{
    [Route("[controller]/[Action]")]
    [ApiController]
    public class ApiController : ControllerBase
    {

        [HttpGet]
        public JsonResult GetSkill()
        {
            TestInHeltContext db = new TestInHeltContext();
            var data = db.Skills.ToList();
            return new JsonResult(data);
        }

        [HttpGet]
        public JsonResult GetSkillLevel()
        {
            TestInHeltContext db = new TestInHeltContext();
            var data = db.SkillLevels.ToList();
            return new JsonResult(data);
        }

    }
}
