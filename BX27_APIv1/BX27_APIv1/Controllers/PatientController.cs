using System.Collections.Generic;
using System.Web.Http;

namespace BX27_APIv1.Controllers
{
    public class PatientController : ApiController
    {
        [HttpGet]
        [Route("v1/Patients/Select")]

        public List<usp_BX27_MED_Patients_Select4API_Result> Post([FromBody] Models.Patients model)
        {
            List<usp_BX27_MED_Patients_Select4API_Result> v_Result = new List<usp_BX27_MED_Patients_Select4API_Result>();
            //v_Result = BX27_APIv1.Models.Login.LoginSelect(model.eMail, model.pwd, model.appNm, model.iPAddr, model.browser);
            v_Result = BX27_APIv1.Models.Patients.PatientsSelect(model.Sys_Account_ID, model.Sys_User_ID, model.Patient_ID);
            return v_Result;
        }
    }
}