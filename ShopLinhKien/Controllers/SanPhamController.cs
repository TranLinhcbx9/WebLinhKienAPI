using API_Data.DAO;
using API_Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShopLinhKien.Controllers
{
    public class SanPhamController : ApiController
    {

        //GET: api/SanPham

        [Route("listsanpham")]

        public IHttpActionResult Get()
        {
            List<SanPham> item = SanPhamDAO.Instance.GetList();
            if (item.Count == 0)
            {
                return NotFound();
            }
            return Ok(item);
        }

        // POST: api/SanPham

        [Route("themsanpham")]
        public IHttpActionResult Post([FromBody] SanPham x)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            SanPhamDAO.Instance.Create(x.masp, x.tensp, x.soluong, x.dongia, x.mota, x.giakm, x.maloaisp);
            return Ok();
        }
        
        //PUT: api/SanPham/5
        public IHttpActionResult Put([FromBody] SanPham x)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid data");
            SanPhamDAO.Instance.Update(x.masp, x.tensp, x.soluong, x.dongia, x.mota, x.giakm, x.maloaisp);
            return Ok();
        }
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/SanPham/5
        //public void Delete(int id)
        //{
        //}
    }
}
