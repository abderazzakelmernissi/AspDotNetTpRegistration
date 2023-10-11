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
    public partial class WebForm1 : System.Web.UI.Page
    {
        public SqlConnection cn = new SqlConnection("Data Source=user6eb4;Initial Catalog=ASPTPINSCR;Integrated Security=True");
        public SqlCommand cmd = new SqlCommand();


        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select nom,pw from user1 where nom ='" + TextBox1.Text+"'";
            cn.Open();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                if (TextBox1.Text == dr[0].ToString() && TextBox2.Text == dr[1].ToString())
                {
                    Label5.Text = "bien authentifier";
                    Label5.Visible = true;
                    Response.Redirect("http://www.google.com");
                }
                else
                {


                    if (TextBox1.Text == dr[0].ToString() && TextBox2.Text != dr[1].ToString())
                    {
                        Label5.Text = "Le Mot de pass est inccorect";
                        Label5.Visible = true;
                        
                    }

                }
            }
            else
            {

                Label5.Text = "le login est incorect";
                Label5.Visible = true;
                
                
                
            }
            if (TextBox1.Text == "") { Label2.Visible = true; }
            if (TextBox2.Text == "") { Label4.Visible = true; } 
           
            
            cn.Close();
            
        }
    }
}