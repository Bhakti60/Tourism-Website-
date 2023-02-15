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


public partial class print : System.Web.UI.Page
{
    OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Project\majorproject.mdb");
    protected void Page_Load(object sender, EventArgs e)
    {
        
           
                Label2.Text = Session["username"].ToString();
                Label3.Text = Session["address"].ToString();
                Label4.Text = Session["mobile"].ToString();
                Label5.Text = Session["pan"].ToString();
                Label6.Text = Session["ac"].ToString();
                Label7.Text = Session["per"].ToString();
                Label8.Text = Session["age"].ToString();
                Label9.Text = Session["gndr"].ToString();
                Label10.Text = Session["pack"].ToString();
              
                Label13.Text = Session["date"].ToString();
                

           
           
       }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}

  
