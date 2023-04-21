using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BX27_APIv1.Models
{
    public class Login
    {
        public string eMail { get; set; }
        public string pwd { get; set; }
        public string appNm { get; set; }
        public string iPAddr { get; set; }
        public string browser { get; set; }
        public static List<usp_BX27_Sys_Users_Login4API_Result> LoginSelect(
                            string p_eMail, string p_pwd, string p_appNm, string p_iPAddr, string p_browser)
        {
            List<usp_BX27_Sys_Users_Login4API_Result> v_List = new List<usp_BX27_Sys_Users_Login4API_Result>();

            using (SqlConnection v_Con = new SqlConnection(ConfigurationManager.ConnectionStrings["BX27_Conn"].ToString()))
            {
                string v_Cmd_Usp = "usp_BX27_Sys_Users_Login";

                try
                {
                    using (SqlCommand v_Cmd = new SqlCommand(v_Cmd_Usp, v_Con))
                    {
                        v_Cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        v_Cmd.Parameters.Add(new SqlParameter("@EMail", p_eMail));
                        v_Cmd.Parameters.Add(new SqlParameter("@Pwd", p_pwd));
                        v_Cmd.Parameters.Add(new SqlParameter("@App_Nm", p_appNm));
                        v_Cmd.Parameters.Add(new SqlParameter("@IP_Addr", p_iPAddr));
                        v_Cmd.Parameters.Add(new SqlParameter("@Browser", p_browser));

                        v_Con.Open();

                        using (SqlDataReader v_Reader = v_Cmd.ExecuteReader())
                        {
                            if (v_Reader.HasRows)
                            {
                                while (v_Reader.Read())
                                {
                                    usp_BX27_Sys_Users_Login4API_Result v_Result = new usp_BX27_Sys_Users_Login4API_Result();

                                    v_Result.Result_Cd = Convert.ToString(v_Reader["Result_Cd"]);
                                    v_Result.Sys_Account_ID = Convert.ToInt32(v_Reader["Sys_Account_ID"]);
                                    v_Result.Sys_Account_Nm = Convert.ToString(v_Reader["Sys_Account_Nm"]);
                                    v_Result.Ctry_Cd = Convert.ToString(v_Reader["Ctry_Cd"]);
                                    v_Result.Currency_Cd = Convert.ToString(v_Reader["Currency_Cd"]);
                                    v_Result.GMT = Convert.ToString(v_Reader["GMT"]);
                                    v_Result.Sys_User_ID = Convert.ToInt32(v_Reader["Sys_User_ID"]);
                                    v_Result.User_Nm = Convert.ToString(v_Reader["User_Nm"]);
                                    v_Result.User_EMail = Convert.ToString(v_Reader["User_EMail"]);
                                    v_Result.User_Gender = Convert.ToString(v_Reader["User_Gender"]);
                                    v_Result.User_Profile_Pic = Convert.ToString(v_Reader["User_Profile_Pic"]);
                                    v_Result.Specialty_Nm = Convert.ToString(v_Reader["Specialty_Nm"]);
                                    v_Result.Place_Nm = Convert.ToString(v_Reader["Place_Nm"]);
                                    v_Result.Tax_Cd = Convert.ToString(v_Reader["Tax_Cd"]);
                                    v_Result.Tax_Nm = Convert.ToString(v_Reader["Tax_Nm"]);
                                    v_Result.Users_Qty = Convert.ToInt32(v_Reader["Users_Qty"]);
                                    v_Result.Patients_Qty = Convert.ToInt32(v_Reader["Patients_Qty"]);
                                    v_Result.Calendars_Qty = Convert.ToInt32(v_Reader["Calendars_Qty"]);
                                    v_Result.Files_Qty = Convert.ToInt32(v_Reader["Files_Qty"]);
                                    v_Result.Accnts_Qty = Convert.ToInt32(v_Reader["Accnts_Qty"]);
                                    v_Result.Prod_Cd = Convert.ToString(v_Reader["Prod_Cd"]);
                                    v_Result.Prod_Nm = Convert.ToString(v_Reader["Prod_Nm"]);
                                    v_Result.Users_Max = Convert.ToInt32(v_Reader["Users_Max"]);
                                    v_Result.Patients_Max = Convert.ToInt32(v_Reader["Patients_Max"]);
                                    v_Result.Calendars_Max = Convert.ToInt32(v_Reader["Calendars_Max"]);
                                    v_Result.Files_Max = Convert.ToInt32(v_Reader["Files_Max"]);
                                    v_Result.Roles = Convert.ToString(v_Reader["Roles"]);
                                    v_Result.Created_On = Convert.ToString(v_Reader["Created_On"]);
                                    v_Result.Owner_ID = Convert.ToInt32(v_Reader["Owner_ID"]);
                                    v_Result.Weight_UM = Convert.ToString(v_Reader["Weight_UM"]);
                                    v_Result.VAT_Pct = Convert.ToString(v_Reader["VAT_Pct"]);
                                    v_Result.User_First_Nm = Convert.ToString(v_Reader["User_First_Nm"]);
                                    v_Result.User_DOB = Convert.ToString(v_Reader["User_DOB"]);
                                    v_Result.Show_Welcome_Config_YN = Convert.ToString(v_Reader["Show_Welcome_Config_YN"]);
                                    v_Result.Result_Msg = "OK";
                                    v_List.Add(v_Result);
                                }

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    usp_BX27_Sys_Users_Login4API_Result v_ResulError = new usp_BX27_Sys_Users_Login4API_Result();

                    v_ResulError.Result_Cd = "ER";
                    v_ResulError.Result_Msg = ex.ToString();
                    v_List.Add(v_ResulError);
                }

            }
            return v_List;

        }
    }
}