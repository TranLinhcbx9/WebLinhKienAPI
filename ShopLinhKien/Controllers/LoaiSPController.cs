using API_Data.DTO;
using API_Data.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShopLinhKien.Controllers
{
    public class LoaiSPController : ApiController
    {
        //GET: api/LoaiSP

        [Route("listloaisp")]

        public IHttpActionResult Get()
        {
            List<LoaiSP> item = LoaiSPDAO.Instance.GetList();
            if (item.Count == 0)
            {
                return NotFound();
            }
            return Ok(item);
        }

        // POST: api/SanPham

        [Route("themloaisp")]
        public IHttpActionResult Post([FromBody] LoaiSP x)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            LoaiSPDAO.Instance.Create(x.maloaisp, x.tenloai);
            return Ok();
        }
        //// GET: api/LoaiSP
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET: api/LoaiSP/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/LoaiSP
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT: api/LoaiSP/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/LoaiSP/5
        //public void Delete(int id)
        //{
        //}
    }
}
