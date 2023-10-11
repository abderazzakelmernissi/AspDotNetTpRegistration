using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace AspTpInscri
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        public SqlConnection cn = new SqlConnection("Data Source=user6eb4;Initial Catalog=ASPTPINSCR;Integrated Security=True");
        public SqlCommand cmd = new SqlCommand();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_LoggedIn(object sender, EventArgs e)
        {

        }

        protected void Login1_LoggingIn(object sender, LoginCancelEventArgs e)
        {
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Username , UserPass from User2 where Username = '"+ Login1.UserName.ToString() +"'";
            cn.Open();
            SqlDataReader dr;
            
            dr = cmd.ExecuteReader();
            dr.Close();
            cn.Close();

            //if ((Login1.UserName.ToString() == dr[0].ToString()) && (Login1.Password.ToString() == dr[1].ToString()))
            //{
            //}

            
            

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {

        }
    }
}