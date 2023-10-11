using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace AspTpInscri
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        public SqlConnection cn = new SqlConnection("Data Source=user6eb4;Initial Catalog=ASPTPINSCR;Integrated Security=True");
        public SqlCommand cmd = new SqlCommand();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DropDownList1.Items.Add("--choisir--");
                DropDownList1.Items.Add("quel est le nom de votre ami preferé ?");
                DropDownList1.Items.Add("quel est votre primaire ecole ?");
                DropDownList1.Items.Add("quel votre ville de naissance ?");
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text == "" && TextBox3.Text == "" && TextBox4.Text == "" && TextBox5.Text == "" && DropDownList1.Text == "--choisir--" && TextBox7.Text == "")
            { Label4.Visible=true;
            Label8.Visible = true;
            Label10.Visible = true;
            Label12.Visible = true;
            Label14.Visible = true;
            }else{

                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into user1 values (@a,@b,@c,@d,@e)";
                cmd.Parameters.AddWithValue("@a", TextBox2.Text);
                cmd.Parameters.AddWithValue("@b", TextBox3.Text);
                cmd.Parameters.AddWithValue("@c", TextBox4.Text);
                if (DropDownList1.SelectedItem.ToString() != "--choisir--")
                    cmd.Parameters.AddWithValue("@d", DropDownList1.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@e", TextBox7.Text);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                }
            
        }
    }
}