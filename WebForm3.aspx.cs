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
    public partial class WebForm3 : System.Web.UI.Page
    {
        public SqlConnection cn = new SqlConnection("Data Source=user6eb4;Initial Catalog=ASPTPINSCR;Integrated Security=True");
        public SqlCommand cmd = new SqlCommand();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CreateUserWizard1_CreatingUser(object sender, LoginCancelEventArgs e)
        {
            

        }

        protected void CreateUserWizard1_CreatedUser(object sender, EventArgs e)
        {
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into User2 values (@a,@b,@c,@d,@e)";
            cmd.Parameters.AddWithValue("@a", CreateUserWizard1.UserName.ToString());
            cmd.Parameters.AddWithValue("@b", CreateUserWizard1.Password.ToString());
            cmd.Parameters.AddWithValue("@c", CreateUserWizard1.Email.ToString());
            cmd.Parameters.AddWithValue("@d", CreateUserWizard1.Question.ToString());
            cmd.Parameters.AddWithValue("@e", CreateUserWizard1.Answer.ToString());
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

        }
    }
}