using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginValidation
{
    public partial class LoginValidation : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void ExecuteInsert(string name, string username, string password, string gender, string age, string address)
        {
            SqlConnection conn = new SqlConnection("Data Source=(localdb)\\ProjectsV12;Initial Catalog=Information;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            try
            {
                conn.Open();
                string sql = "INSERT INTO InfoTable (Name, UserName, Password, Gender, Age, Address) VALUES "
                        + " (@Name,@UserName,@Password,@Gender,@Age,@Address)";
                                
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlParameter[] param = new SqlParameter[6];
                //param[0] = new SqlParameter("@id", SqlDbType.Int, 20);
                param[0] = new SqlParameter("@Name", SqlDbType.VarChar, 50);
                param[1] = new SqlParameter("@UserName", SqlDbType.VarChar, 50);
                param[2] = new SqlParameter("@Password", SqlDbType.VarChar, 50);
                param[3] = new SqlParameter("@Gender", SqlDbType.Char, 10);
                param[4] = new SqlParameter("@Age", SqlDbType.Int, 100);
                param[5] = new SqlParameter("@Address", SqlDbType.VarChar, 50);

                param[0].Value = name;
                param[1].Value = username;
                param[2].Value = password;
                param[3].Value = gender;
                param[4].Value = age;
                param[5].Value = address;

                for (int i = 0; i < param.Length; i++)
                {
                    cmd.Parameters.Add(param[i]);
                }
                if(TxtPassword.Text == TxtRePassword.Text)
                {
                    if (TxtName.Text != "" && TxtUserName.Text != "" && TxtPassword.Text != "" && TxtRePassword.Text != "" && TxtAddress.Text != "" && TxtAge.Text != "" && DropDownList1.Text != "")
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        TxtName.Text = "";
                        TxtUserName.Text = "";
                        TxtPassword.Text = "";
                        TxtRePassword.Text = "";
                        TxtAddress.Text = "";
                        TxtAge.Text = "";
                        DropDownList1.Text = "Select";
                        string script = "alert(\"Registered succesfully.\");";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "ServerControlScript", script, true);
                        Response.Write("Registered successfully");
                        Response.Redirect("SignUp.aspx", true);


                    }
                    else
                    {
                        string script1 = "alert(\"Fill in all the details.\");";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "ServerControlScript", script1, true);
                        
                    }
                }
                else
                {
                    string script1 = "alert(\"Passwords did not match.\");";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "ServerControlScript", script1, true);
                    TxtPassword.Focus();
                }


            }
            catch (SqlException ex)
            {
                Response.Write("Could not connect to database: " + ex.Message);
            }
            catch (Exception ex)
            {
                Response.Write("Could not connect to database: " + ex.Message);
            }
            
        }
        protected void Sign_In(object sender, EventArgs e)
        {
                //call the method to execute insert to the database
                ExecuteInsert(TxtName.Text,
                              TxtUserName.Text,
                              TxtPassword.Text,
                              DropDownList1.SelectedItem.Text,
                              TxtAge.Text, TxtAddress.Text);
            
                
                
            
        }

        protected void Log_In(object sender, EventArgs e)
        {
            Response.Redirect("SignUp.aspx", true);
        }


    }
}