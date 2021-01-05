using API_Data.DAO;
using API_Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShopLinhKien.Controllers
{
    public class LinhKienController : ApiController
    {
        // GET: api/LinhKien
        [HttpGet]
        [Route("listlinhkien")]

        public List<LinhKien> GetListLinhKien()
        {
            return new LinhKienDAO.GetListLinhKien();
            //LinhKienDAO dao = new LinhKienDAO();
            //return dao.GetListLinhKien();

        }

        // GET: api/LinhKien/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/LinhKien
        //[Route("themlinhkien")]
        //public IHttpActionResult Post([FromBody] LinhKien x)
        //{
        //    if (!ModelState.IsValid)
        //        return BadRequest("Not a valid model");

        //    LinhKienDAO.Instance.CreateLinhKien(x.maloailinhkien, x.manhacungcap, x.maloaimay, x.tenlinhkien, x.thongsokithuat, x.mota, x.giaban, x.thoigianbaohanh);
        //    return Ok();
        //}

        // PUT: api/LinhKien/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/LinhKien/5
        public void Delete(int id)
        {
        }
    }
}
