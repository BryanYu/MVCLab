using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OneCenter.WebAPI.Controllers
{
    /// <summary>
    /// 帳號控制器
    /// </summary>
    public class AccountController : ApiController
    {
        /// <summary>
        /// 取得帳號
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IHttpActionResult Get()
        {
            return this.Ok();
        }

        /// <summary>
        /// 新增帳號
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IHttpActionResult Post()
        {
            return this.Ok();
        }

        /// <summary>
        /// 更新帳號
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        public IHttpActionResult Put()
        {
            return this.Ok();
        }

        /// <summary>
        /// 刪除帳號
        /// </summary>
        /// <returns></returns>
        [HttpDelete]
        public IHttpActionResult Delete()
        {
            return this.Ok();
        }
    }
}