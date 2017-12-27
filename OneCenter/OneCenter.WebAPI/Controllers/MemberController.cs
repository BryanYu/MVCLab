using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OneCenter.WebAPI.Controllers
{
    /// <summary>
    /// 會員控制器
    /// </summary>
    public class MemberController : ApiController
    {
        /// <summary>
        /// 取得會員
        /// </summary>
        /// <param name="userName">會員名稱</param>
        /// <param name="phone">手機</param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetMember")]
        public IHttpActionResult GetMember(string userName, string phone)
        {
            return this.Ok();
        }

        /// <summary>
        /// 新增會員
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("AddMember")]
        public IHttpActionResult AddMember()
        {
            return this.Ok();
        }

        /// <summary>
        /// 更新會員
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("UpdateMember")]
        public IHttpActionResult UpdateMember()
        {
            return this.Ok();
        }

        /// <summary>
        /// 刪除會員
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("DeleteMember")]
        public IHttpActionResult DeleteMember()
        {
            return this.Ok();
        }
    }
}