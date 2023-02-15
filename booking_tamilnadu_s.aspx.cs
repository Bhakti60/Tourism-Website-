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


public partial class booking_tamilnadu_s : System.Web.UI.Page
{
    static String MyOtp = "";
    static  int OTP = 0;
    private static Random random = new Random();
    OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Project\majorproject.mdb");
    protected void Page_Load(object sender, EventArgs e)
    {
        display();
    }

    public static string RandomString(int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        return new string(Enumerable.Repeat(chars, length)
          .Select(s => s[random.Next(s.Length)]).ToArray());
    }

            public void clr()
        {
            TextBox1.Text= "";
            TextBox2.Text = "";
            TextBox4.Text = "";
            TextBox6.Text = ""; 
            TextBox7.Text = "";



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
        double mob = Convert.ToDouble(TextBox7.Text);
        if (mob >= 7000000000 && mob <= 9999999999 && OTP == 1)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandText = "Insert into registration values('"
                                + TextBox1.Text + "','"
                                + TextBox3.Text + "','"
                                + TextBox4.Text + "','"
                                + TextBox6.Text + "','"
                                + TextBox7.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Data Insert Successfully...');", true);
            clr();
            display();
            
        }
        else
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Invalid mobile no OR OTP ');", true);
            
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("login.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        //generate otp 
        MyOtp = RandomString(4);

        //sender email
        MailMessage mail = new MailMessage();
        mail.To.Add(TextBox4.Text + ""); // use ur email id for demo
        // mail.CC.Add("pranavwankhede5@gmail.com");
        mail.CC.Add("bhaktimejari22@gmail.com");

        mail.From = new MailAddress("bhaktimejari22@gmail.com");
        mail.Subject = "OPT - travel System!";
        string Body = "Your OTP is : " + MyOtp + "\nDo not Share with Other!";
        mail.Body = Body;
        SmtpClient smtp = new SmtpClient();
        smtp.Host = "smtp.gmail.com"; //Or Your SMTP Server Address
        smtp.Port = 587;
        smtp.UseDefaultCredentials = false;
        smtp.Credentials = new System.Net.NetworkCredential("bhaktimejari22@gmail.com", "bhakti mejari22");

        //Or your Smtp Email ID and Password
        smtp.EnableSsl = true;
        smtp.Send(mail);
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        //check otp
        if (TextBox5.Text==MyOtp)
        {
            OTP = 1;
              ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Matched..');", true);
          
        }
        else
        {
            OTP = 0;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('not matched...');", true);
          
        }
    }
    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {

    }
}