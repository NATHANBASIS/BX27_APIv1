using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BX27_APIv1.Controllers
{
    public class LoginController : ApiController
    {
        // GET api/<controller>
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // [System.Web.Http.AcceptVerbs("GET", "POST")]
        [HttpPost]
        [Route("v1/Users/Login")]

        public List<usp_BX27_Sys_Users_Login4API_Result> Post([FromBody] Models.Login model)
        {
            List<usp_BX27_Sys_Users_Login4API_Result> v_Result = new List<usp_BX27_Sys_Users_Login4API_Result>();
            v_Result = BX27_APIv1.Models.Login.LoginSelect(model.eMail, model.pwd, model.appNm, model.iPAddr, model.browser);
            return v_Result;
        }

        //// GET api/<controller>/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<controller>
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<controller>/5
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<controller>/5
        //public void Delete(int id)
        //{
        //}
    }
}