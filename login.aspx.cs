using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;


public partial class login : System.Web.UI.Page
{
    string pass, id;
    OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Project\majorproject.mdb");
    protected void Page_Load(object sender, EventArgs e)
    {
        display();
    }
        public void clr()
        {
            TextBox1.Text= "";
            TextBox2.Text = "";
          
        }

            public void display()
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                
                cmd.CommandText = "select * from registration";
                cmd.ExecuteNonQuery();
                con.Close();
            }
    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        String query = "select * from registration where USERNAME = '"
                            + TextBox1.Text + "'";
        OleDbCommand cmd = new OleDbCommand(query, con);
        OleDbDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            id = dr["USERNAME"].ToString();
            pass = dr["PASSWORD"].ToString();
            
            if (pass == TextBox2.Text)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Password mathched......');", true);
                Response.Redirect("ticket_tamilnadu_s.aspx");
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('pass not matched......');", true);
            }
        }
        else
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('NO RECORD FOUND......');", true);
        }
        con.Close();


    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("booking_tamilnadu_s.aspx");
        
    }
    
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("forgetpassword.aspx");
    }
}