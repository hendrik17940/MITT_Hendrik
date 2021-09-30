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

        [HttpPost]
        public JsonResult AddSkill(SkillHelper skillHelper)
        {
            TestInHeltContext db = new TestInHeltContext();
            Skill skill = new Skill();
            skill.SkillName = skillHelper.SkillName;

            db.Skills.Add(skill);
            db.SaveChanges();
            return new JsonResult("Tambah Berhasil");
        }

        [HttpPost]
        public JsonResult AddSkillLevel(SkillLevelHelper skillLevelHelper)
        {
            TestInHeltContext db = new TestInHeltContext();
            SkillLevel skilllevel = new SkillLevel();
            skilllevel.SkillLevelName = skillLevelHelper.SkillLevelName;

            db.SkillLevels.Add(skilllevel);
            db.SaveChanges();
            return new JsonResult("Tambah Berhasil");
        }

        [HttpPatch]
        public JsonResult UpdateSkill(SkillHelperUpdate skillHelperUpdate)
        {
            TestInHeltContext db = new TestInHeltContext();
            Skill skill = new Skill();
            skill.SkillId = skillHelperUpdate.SkillId;
            skill.SkillName = skillHelperUpdate.SkillName;

            db.Entry(skillHelperUpdate).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return new JsonResult("Update Berhasil");
        }

        [HttpPatch]
        public JsonResult UpdateSkillLevel(SkillLevelHelperUpdate skillLevelHelperUpdate)
        {
            TestInHeltContext db = new TestInHeltContext();
            SkillLevel skillLevel = new SkillLevel();
            skillLevel.SkillLevelId = skillLevelHelperUpdate.SkillLevelId;
            skillLevel.SkillLevelName = skillLevelHelperUpdate.SkillLevelName;

            db.Entry(skillLevelHelperUpdate).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return new JsonResult("Update Berhasil");
        }

    }
}
