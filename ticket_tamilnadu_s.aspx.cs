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

using System.Net.Mail;


public partial class ticket_tamilnadu_s : System.Web.UI.Page
{
    OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Project\majorproject.mdb");
    protected void Page_Load(object sender, EventArgs e)
    {
        display();
    }

    public void clr()
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";
        TextBox7.Text = "";
        DropDownList1.Text = "";
        DropDownList2.Text = "";
      
        


      


    }

    public void display()
    {
        con.Open();
        OleDbCommand cmd = con.CreateCommand();

        cmd.CommandText = "select * from Ticket";
        cmd.ExecuteNonQuery();
        con.Close();
    }


    protected void TextBox6_TextChanged(object sender, EventArgs e)
    {

    }
    
    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        OleDbCommand cmd = con.CreateCommand();
        cmd.CommandText = "Insert into Ticket values('"
        + TextBox1.Text + "','"
       + TextBox2.Text + "','"
        + TextBox3.Text + "','"
        + TextBox4.Text + "','"
        + TextBox5.Text + "','"
        + TextBox6.Text + "','"
        + TextBox7.Text + "','"
        + DropDownList1.Text + "','"
        + DropDownList2.Text + "','"
        + TextBox12.Text + "')";
        cmd.ExecuteNonQuery();
        con.Close();
       
        Session["username"] = TextBox1.Text;
        Session["date"] = TextBox12.Text;
        Session["address"] = TextBox2.Text;
        Session["mobile"] = TextBox3.Text;
        Session["pan"] = TextBox4.Text;
        Session["ac"] = TextBox5.Text;
        Session["per"] = TextBox6.Text;
        Session["age"] = TextBox7.Text;
        Session["gndr"] = DropDownList1.Text;
        Session["pack"] = DropDownList2.Text;
        
       
        
        Response.Redirect("print.aspx");
    }


   
    protected void TextBox11_TextChanged(object sender, EventArgs e)
    {

    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        if (DropDownList4.SelectedIndex.Equals(0))
        {
            Response.Redirect("Creditcard.aspx");
        }
        else if (DropDownList4.SelectedIndex.Equals(1))
        {
            Response.Redirect("Debitcard.aspx");
        }
    }
    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
