using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginValidation
{
    public partial class SignUp : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source=(localdb)\\ProjectsV12;Initial Catalog=Information;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void ExecuteLogin(string username, string password)
        {
            SqlCommand command = new SqlCommand("SELECT UserName, Password FROM InfoTable;", conn);
            string col1 = "", col2 = "";
            
            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        col1 = reader.GetString(0);
                        col2 = reader.GetString(1);
                        if (username == col1 && password == col2)
                        {
                            Response.Redirect("Home.aspx", true);
                        }
                        
                    }

                }
                else
                {
                    Response.Write("No rows found.");
                }
                reader.Close();

            }
            catch (Exception e)
            {
                Response.Write(e.Message);
            }
            
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            ExecuteLogin(TxtUserName.Text,
                              TxtPassword.Text);

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("LoginValidation.aspx", true);

        }

    }
}