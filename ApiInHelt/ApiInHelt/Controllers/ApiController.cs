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




        //[HttpGet]
        //[Authorize]
        //public JsonResult DataList()
        //{
        //    db_latihanContext db = new db_latihanContext();
        //    var data = db.TblPegawais.ToList();
        //    return new JsonResult(data);
        //}

        //[HttpPost]
        //public JsonResult DataAdd(TblPegawai tblpegawai)
        //{
        //    db_latihanContext db = new db_latihanContext();

        //    db.TblPegawais.Add(tblpegawai);
        //    db.SaveChanges();
        //    return new JsonResult("Add sukses");
        //}

        //[HttpPatch]
        //public JsonResult DataUpdate(TblPegawai tblpegawai)
        //{
        //    db_latihanContext db = new db_latihanContext();
        //    db.Entry(tblpegawai).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        //    db.SaveChanges();

        //    return new JsonResult("Berhasil update");
        //}

        //[HttpDelete]
        //public JsonResult DataDelete(int IdPegawai)
        //{
        //    db_latihanContext db = new db_latihanContext();
        //    db.Remove(db.TblPegawais.Where(e => e.Idpegawai == IdPegawai).FirstOrDefault());
        //    db.SaveChanges();
        //    return new JsonResult("Berhasil delete");
        //}
    }
}
