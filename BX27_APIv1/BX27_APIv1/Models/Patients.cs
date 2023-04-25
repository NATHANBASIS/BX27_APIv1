using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace BX27_APIv1.Models
{ 
    public class Patients 
    { 
        public int Sys_Account_ID { get; set; }

        public int Sys_User_ID { get; set; }

        public int Patient_ID { get; set; }

        public static List<usp_BX27_MED_Patients_Select4API_Result> PatientsSelect(
                            int p_Sys_Account_ID, int p_Sys_User_ID, int p_Patient_ID)
        {
            List<usp_BX27_MED_Patients_Select4API_Result> v_List = new List<usp_BX27_MED_Patients_Select4API_Result>();

            using (SqlConnection v_Con = new SqlConnection(ConfigurationManager.ConnectionStrings["BX27_Conn"].ToString()))
            {
                string v_Cmd_Usp = "usp_BX27_MED_Patients_Select";

                try
                {
                    using (SqlCommand v_Cmd = new SqlCommand(v_Cmd_Usp, v_Con))
                    {
                        v_Cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        v_Cmd.Parameters.Add(new SqlParameter("@Sys_Account_ID", p_Sys_Account_ID));
                        v_Cmd.Parameters.Add(new SqlParameter("@Sys_User_ID", p_Sys_User_ID));
                        v_Cmd.Parameters.Add(new SqlParameter("@Patient_ID", p_Patient_ID));

                        v_Con.Open();

                        using (SqlDataReader v_Reader = v_Cmd.ExecuteReader())
                        {
                            if (v_Reader.HasRows)
                            {
                                while (v_Reader.Read())
                                {
                                    usp_BX27_MED_Patients_Select4API_Result v_Result = new usp_BX27_MED_Patients_Select4API_Result();

                                    v_Result.Result_Cd = "";
                                    v_Result.Patient_ID = Convert.ToInt32(v_Reader["Patient_ID"]);
                                    v_Result.First_Nm1 = Convert.ToString(v_Reader["First_Nm1"]);
                                    v_Result.First_Nm2 = Convert.ToString(v_Reader["First_Nm2"]);
                                    v_Result.Last_Nm1 = Convert.ToString(v_Reader["Last_Nm1"]);
                                    v_Result.Last_Nm2 = Convert.ToString(v_Reader["Last_Nm2"]);
                                    v_Result.Last_Nm3 = Convert.ToString(v_Reader["Last_Nm3"]);
                                    v_Result.File_No = Convert.ToString(v_Reader["File_No"]);
                                    v_Result.DOB = Convert.ToString(v_Reader["DOB"]);
                                    v_Result.Gender = Convert.ToString(v_Reader["Gender"]);
                                    v_Result.Prefix_Nm = Convert.ToString(v_Reader["Prefix_Nm"]);
                                    v_Result.Notes = Convert.ToString(v_Reader["Notes"]);
                                    v_Result.File_Hash = Convert.ToString(v_Reader["File_Hash"]);
                                    v_Result.vw_Age = Convert.ToString(v_Reader["vw_Age"]);
                                    v_Result.Life_Status = Convert.ToString(v_Reader["Life_Status"]);
                                    v_Result.DOD = Convert.ToString(v_Reader["DOD"]);
                                    v_Result.Family_Group = Convert.ToString(v_Reader["Family_Group"]);
                                    v_Result.Ctry_Cd = Convert.ToString(v_Reader["Ctry_Cd"]);
                                    v_Result.Phone1 = Convert.ToString(v_Reader["Phone1"]);
                                    v_Result.Phone2 = Convert.ToString(v_Reader["Phone2"]);
                                    v_Result.EMail1 = Convert.ToString(v_Reader["EMail1"]);
                                    v_Result.EMail2 = Convert.ToString(v_Reader["EMail2"]);
                                    v_Result.ID_Ty = Convert.ToString(v_Reader["ID_Ty"]);
                                    v_Result.ID_No = Convert.ToString(v_Reader["ID_No"]);
                                    v_Result.vw_First_Nm = Convert.ToString(v_Reader["vw_First_Nm"]);
                                    v_Result.vw_Last_Nm = Convert.ToString(v_Reader["vw_Last_Nm"]);
                                    v_Result.Last_Activ_Dt = Convert.ToString(v_Reader["Last_Activ_Dt"]);
                                    v_Result.vw_Last_Activ_Dt = Convert.ToString(v_Reader["vw_Last_Activ_Dt"]);
                                    v_Result.Calendar_Send_EMail_YN = Convert.ToString(v_Reader["Calendar_Send_EMail_YN"]);
                                    v_Result.Adr_Txt = Convert.ToString(v_Reader["Adr_Txt"]);
                                    v_Result.Adr_Place_ID = Convert.ToString(v_Reader["Adr_Place_ID"]);
                                    v_Result.Responsible_Nm = Convert.ToString(v_Reader["Responsible_Nm"]);
                                    v_Result.Responsible_Rel = Convert.ToString(v_Reader["Responsible_Rel"]);
                                    v_Result.Doc_Ty = Convert.ToString(v_Reader["Doc_Ty"]);
                                    v_Result.Doc_No = Convert.ToString(v_Reader["Doc_No"]);
                                    v_Result.vw_Doc_No = Convert.ToString(v_Reader["vw_Doc_No"]);
                                    v_Result.vw_Status = Convert.ToString(v_Reader["vw_Status"]);
                                    v_Result.Status = Convert.ToString(v_Reader["Status"]);
                                    v_Result.Postal_Cd = Convert.ToString(v_Reader["Postal_Cd"]);
                                    v_Result.Tax_No = Convert.ToString(v_Reader["Tax_No"]);
                                    v_Result.vw_Tax_No = Convert.ToString(v_Reader["vw_Tax_No"]);
                                    v_Result.Marital_Status = Convert.ToString(v_Reader["Marital_Status"]);
                                    v_Result.vw_Marital_Status = Convert.ToString(v_Reader["vw_Marital_Status"]);
                                    v_Result.Ins_YN = Convert.ToString(v_Reader["Ins_YN"]);
                                    v_Result.Ins_Company = Convert.ToString(v_Reader["Ins_Company"]);
                                    v_Result.Ins_Policy = Convert.ToString(v_Reader["Ins_Policy"]);
                                    v_Result.Ins_Certif = Convert.ToString(v_Reader["Ins_Certif"]);
                                    v_Result.Ins_Relation = Convert.ToString(v_Reader["Ins_Relation"]);
                                    v_Result.Ins_Notes = Convert.ToString(v_Reader["Ins_Notes"]);
                                    v_Result.vw_Place_Nm = Convert.ToString(v_Reader["vw_Place_Nm"]);
                                    v_Result.Tax_Cd = Convert.ToString(v_Reader["Tax_Cd"]);
                                    v_Result.Blood_Ty = Convert.ToString(v_Reader["Blood_Ty"]);
                                    v_Result.Profile_Pic_Url = Convert.ToString(v_Reader["Profile_Pic_Url"]);
                                    v_Result.History_Allergies = Convert.ToString(v_Reader["History_Allergies"]);
                                    v_Result.History_Prescs = Convert.ToString(v_Reader["History_Prescs"]);
                                    v_Result.Profession_Nm = Convert.ToString(v_Reader["Profession_Nm"]);
                                    v_Result.vw_User_Roles = Convert.ToString(v_Reader["vw_User_Roles"]);
                                    v_Result.vw_User_Files_View_Allowed_YN = Convert.ToString(v_Reader["vw_User_Files_View_Allowed_YN"]);
                                    v_Result.Tags_Txt = Convert.ToString(v_Reader["Tags_Txt"]);
                                    v_Result.vw_Tags_Txt = Convert.ToString(v_Reader["vw_Tags_Txt"]);
                                    v_Result.vw_Tags_Html = Convert.ToString(v_Reader["vw_Tags_Html"]);
                                    v_Result.vw_Created = Convert.ToString(v_Reader["vw_Created"]);
                                    v_Result.vw_Updated = Convert.ToString(v_Reader["vw_Updated"]);
                                    v_Result.Result_Msg = "OK";
                                    v_List.Add(v_Result);
                                }

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    usp_BX27_MED_Patients_Select4API_Result v_ResulError = new usp_BX27_MED_Patients_Select4API_Result();

                    v_ResulError.Result_Cd = "ER";
                    v_ResulError.Result_Msg = ex.ToString();
                    v_List.Add(v_ResulError);
                }

            }
            return v_List;

        }
    }
}